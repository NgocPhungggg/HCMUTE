import sys
import os
from pathlib import Path
from operator import add
from pyspark.sql import SparkSession
def split_data(line):
    """
    Returns sensorId,1 of readings with temperature above 50
    """
    data = str.split(line, ',')
    key = data[0]  
    temperature = float(data[2])  
    return [key, 1 if temperature > 50 else 0]

def swap_parts(line):
    """
    Swap key and value and return
    """
    return (line[1], line[0])

if __name__ == "__main__":
    input_path = "hdfs://ngocphung-master:9000/spark/ex-40/input.csv"
    output_path = "hdfs://ngocphung-master:9000/spark/ex-40/output"
    # Khởi tạo một SparkSession (một ứng dụng Spark)
    spark = SparkSession.builder.appName('Exercise-34').getOrCreate()
    sc = spark.sparkContext
    absolute_path = Path().absolute()
    # Đọc file đầu vào từ HDFS, mỗi dòng trong file là một phần tử trong RDD
    # VD: ["s1,2016-01-01,20.5", "s2,2016-01-01,30.1"]
    lines = sc.textFile(input_path)
    # Tạo cặp (sensorId, 1 hoặc 0) từ mỗi dòng, tùy thuộc vào nhiệt độ
    # VD Kết quả: [("s1", 0), ("s2", 0), ("s1", 1), ("s2", 0), ("s1", 1), ("s2", 1)]
    lines_key_value = lines.map(split_data)

    # Đếm số dòng có nhiệt độ > 50 cho từng sensorId
    # Sử dụng reduceByKey(add) để cộng tất cả các giá trị (1 hoặc 0) của mỗi sensorId
    # VD Kết quả: [("s1", 2), ("s2", 1)]
    sensors_counter = lines_key_value.reduceByKey(add).map(swap_parts).sortByKey(ascending=False).collect()

    # Print the result on the standard output
    sensors_counter.coalesce(1).saveAsTextFile(output_path)
    spark.stop()