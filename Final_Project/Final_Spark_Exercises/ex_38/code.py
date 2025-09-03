import findspark
# Khởi tạo Spark từ SPARK_HOME
findspark.init()  
import sys
import os
from pathlib import Path
from pyspark.sql import SparkSession
from operator import add

def split_data_add_counter(line):
    data = str.split(line, ',')
    return [data[0], 1]

if __name__ == "__main__":
    input_path = "hdfs://ngocphung-master:9000/BigData/ex-38/input.csv"
    output_path = "hdfs://ngocphung-master:9000/BigData/ex-38/output"
    # Khởi tạo một SparkSession (một ứng dụng Spark)
    spark = SparkSession.builder.appName('Exercise-38').getOrCreate()
    sc = spark.sparkContext
    # Thư mục chứa file code.py
    absolute_path = Path().absolute()
    # Đường dẫn đầy đủ đến input.csv


    lines = sc.textFile(input_path)
        # "s1,2016-01-01,20.5"
        # "s2,2016-01-01,30.1"
        # "s1,2016-01-02,60.2"
        # "s2,2016-01-02,20.4"
        # "s1,2016-01-03,55.5"
        # "s2,2016-01-03,52.5"

    lines_above = lines.filter(lambda x: float(str.split(x,',')[2]) > 50)
        # "s1,2016-01-02,60.2"
        # "s1,2016-01-03,55.5"
        # "s2,2016-01-03,52.5"

    counter_readings = lines_above.map(split_data_add_counter)
        # ("s1", 1), ("s1", 1), ("s2", 1)

    readings_above= counter_readings.reduceByKey(add).filter(lambda x: x[1] > 1)
        # ("s1", 2)

    readings_above.coalesce(1).saveAsTextFile(output_path)
    # Dừng SparkSession để giải phóng tài nguyên
    spark.stop()