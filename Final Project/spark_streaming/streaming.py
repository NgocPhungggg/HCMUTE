import findspark
findspark.init('C:\Spark\spark-3.5.3-bin-hadoop3')
import pyspark
sc = pyspark.SparkContext()
import re
from pyspark.sql import SparkSession
from pyspark.sql.functions import col, udf
from pyspark.sql.types import StringType, StructType, StructField
from pyspark.ml import PipelineModel

# Định nghĩa schema cho file CSV
schema = StructType([
    StructField("id", StringType(), True),
    StructField("company", StringType(), True),
    StructField("label", StringType(), True),
    StructField("tweet", StringType(), True),
])

# Tạo SparkSession và cấu hình cho master cluster
spark = SparkSession.builder.appName("Spark Streaming").master("spark://192.168.1.66:7077").config("spark.executor.memory", "4g").config("spark.executor.cores", "4").getOrCreate()

# Đọc dữ liệu từ file CSV
csv_dir = "C:\Spark\spark_streaming\data"

df = spark \
    .readStream \
    .schema(schema) \
    .option("header", "false") \
    .csv(csv_dir)

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
pipeline = PipelineModel.load('C:\Spark\model_spark\logistic_regression_model.pkl')

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
