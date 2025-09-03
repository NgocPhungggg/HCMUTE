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

# Tạo SparkConf
# conf = SparkConf() \
#     .setAppName("Spark Streaming") \
#     .setMaster("spark://26.89.168.243:7077") \
#     .set("spark.blockManager.port", "10025") \
#     .set("spark.driver.blockManager.port", "10026") \
#     .set("spark.driver.port", "10027") \
#     .set("spark.cores.max", "4") \
#     .set("spark.executor.memory", "1g") \
#     .set("spark.driver.host", "26.89.168.243")

conf = SparkConf() \
    .setAppName("Spark Streaming Windows") \
    .setMaster("spark://26.89.168.243:7077") \
    .set("spark.driver.host", "26.89.168.243") \
    .set("spark.driver.port", "10027") \
    .set("spark.blockManager.port", "10025") \
    .set("spark.port.maxRetries", "50") \
    .set("spark.ui.port", "4041")

# Tạo SparkSession
spark = SparkSession.builder.config(conf=conf).getOrCreate()

# Đọc dữ liệu từ thư mục CSV
csv_dir = "hdfs://ngocphung-master:9000/BigData/FinalProject/spark_streaming/data/"
df = spark.readStream \
    .schema(schema) \
    .option("header", "false") \
    .csv(csv_dir)

# Hàm làm sạch dữ liệu
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

clean_text_udf = udf(clean_text, StringType())

# Tải mô hình đã huấn luyện
# pipeline = PipelineModel.load('C:\\Spark\\model_spark\\logistic_regression_model.pkl')
# csv_dir = "hdfs://ngocphung-master:9000/BigData/FinalProject/model_spark/logistic_regression_model.pkl"
# pipeline = PipelineModel.load('C:\\Spark\\model_spark\\logistic_regression_model.pkl')
pipeline = PipelineModel.load('hdfs://ngocphung-master:9000/BigData/FinalProject/model_spark/logistic_regression_model.pkl')

# Định nghĩa hàm xử lý từng batch dữ liệu
class_index_mapping = {0: 'Negative', 1: 'Positive', 2: 'Neutral', 3: 'Irrelevant'}

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

# Khởi động streaming query
query = df.writeStream \
    .foreachBatch(process_batch) \
    .outputMode('append') \
    .start()

query.awaitTermination()

# Dừng SparkSession khi kết thúc
spark.stop()
