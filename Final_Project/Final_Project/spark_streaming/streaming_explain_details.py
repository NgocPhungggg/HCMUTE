import re
from pyspark import SparkConf
from pyspark.sql import SparkSession
from pyspark.sql.functions import col, udf
from pyspark.sql.types import StringType, StructType, StructField
from pyspark.ml import PipelineModel
import sys
sys.stdout.reconfigure(encoding='utf-8')
# Định nghĩa schema cho file CSV
schema = StructType([
    StructField("id", StringType(), True),
    StructField("company", StringType(), True),
    StructField("label", StringType(), True),
    StructField("tweet", StringType(), True),
])

conf = SparkConf() \
    .setAppName("Spark Streaming Windows") \
    .setMaster("spark://26.89.168.243:7077") \
    .set("spark.driver.host", "26.89.168.243") \
    .set("spark.driver.port", "10027") \
    .set("spark.blockManager.port", "10025") \
    .set("spark.port.maxRetries", "50") \
    .set("spark.ui.port", "4041")

spark = SparkSession.builder.config(conf=conf).getOrCreate()

csv_dir = "hdfs://ngocphung-master:9000/BigData/FinalProject/spark_streaming/data/"
df = spark.readStream \
    .schema(schema) \
    .option("header", "false") \
    .csv(csv_dir)

# Mục đích: Làm sạch nội dung tweet:
# Loại bỏ URL, địa chỉ website.
# Loại bỏ mentions (@username) và hashtags (#hashtag).
# Chuyển toàn bộ văn bản sang chữ thường.
# Loại bỏ các ký tự không phải chữ cái.
# Loại bỏ khoảng trắng thừa.
def clean_text(text):
    if text is not None:
        text = re.sub(r'https?://\S+|www\.\S+|\.com\S+|youtu\.be/\S+', '', text)
        text = re.sub(r'(@|#)\w+', '', text)
        text = text.lower()
        text = re.sub(r'[^a-zA-Z\s]', '', text)
        text = re.sub(r'\s+', ' ', text).strip()
        return text
    else:
        return ''


#Định nghĩa một UDF để áp dụng hàm clean_text lên các cột của DataFrame.
clean_text_udf = udf(clean_text, StringType())

# Mục đích: Tải một mô hình Logistic Regression đã được huấn luyện từ HDFS.
pipeline = PipelineModel.load('hdfs://ngocphung-master:9000/BigData/FinalProject/model_spark/logistic_regression_model.pkl')

# Mục đích: Ánh xạ các giá trị dự đoán (0, 1, 2, 3) thành tên lớp (Negative, Positive, Neutral, Irrelevant).
class_index_mapping = {0: 'Negative', 1: 'Positive', 2: 'Neutral', 3: 'Irrelevant'}


# Làm sạch văn bản bằng clean_text_udf.
# Áp dụng mô hình đã tải (pipeline) để dự đoán sentiment.
# In kết quả:
# Nội dung tweet gốc.
# Nội dung đã làm sạch.
# Giá trị dự đoán (prediction).
# Lớp cảm xúc dự đoán (classname).
def process_batch(batch_df, batch_id):
    batch_df = batch_df.withColumn("text", clean_text_udf(col("tweet")))
    processed_validation = pipeline.transform(batch_df)
    predictions = processed_validation.select("tweet", "text", "prediction").collect()
    
    for row in predictions:
        tweet = row['tweet']
        preprocessed_tweet = row['text']
        prediction = row['prediction']
        prediction_classname = class_index_mapping[int(prediction)]
        
        print("-> Tweet:", tweet)
        print("-> preprocessed_tweet:", preprocessed_tweet)
        print("-> Predicted Sentiment:", prediction)
        print("-> Predicted Sentiment classname:", prediction_classname)

# Xử lý từng batch dữ liệu mới trong df bằng hàm process_batch.
# Giữ luồng streaming hoạt động cho đến khi người dùng dừng nó.
query = df.writeStream \
    .foreachBatch(process_batch) \
    .outputMode('append') \
    .start()
query.awaitTermination()

spark.stop()
