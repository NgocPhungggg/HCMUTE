# -*- coding: utf-8 -*-
"""
Created on Sat Apr 15 15:07:32 2023

@author: Aashay Patil
"""
from pyspark.sql import SparkSession
from pyspark.sql.functions import *

# Create the SparkSession
spark = SparkSession.\
builder.\
appName("sparkstream").\
getOrCreate()

# Define input sources
lines = (spark\
.readStream.format("socket")\
.option("host", "192.168.1.133")\
.option("port", 9999)\
.load())
#lines = (spark\
#    .readStream
#    .format("text")  # Sử dụng định dạng "text" cho file văn bản. Có thể thay đổi tùy theo định dạng của file bạn đang sử dụng.
#    .load("D:/BDE (Big Data Essential)/Final Project/Spark_Streaming/INPUT_WordCount.txt"))  # Thay "đường_dẫn_đến_file" bằng đường dẫn cụ thể tới file bạn muốn sử dụng.


# Transform data
words = lines.select(split(col("value"), "\\s").alias("word"))

# Get the count of published words
counts = words.groupBy("word").count()

# Define the checkpoint directory
checkpointDir = "C:/checkpoint/"
#checkpointDir = "D:/BDE (Big Data Essential)/Final Project/Spark_Streaming/OUTPUT_Spark_Streaming"

# Start streaming defining the necessary configurations
streamingQuery = (counts
.writeStream
.format("console")
.outputMode("complete")
.trigger(processingTime="1 second")
.option("checkpointLocation", checkpointDir)
.start())
streamingQuery.awaitTermination()