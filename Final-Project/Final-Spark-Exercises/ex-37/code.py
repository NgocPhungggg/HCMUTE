import findspark
# Khởi tạo Spark từ SPARK_HOME
findspark.init()  
import sys
import os
from pathlib import Path
# Import SparkSession để làm việc với Spark
from pyspark.sql import SparkSession
# Hàm xử lý từng dòng trong file CSV
def split_data(line):
    data = str.split(line, ',')
    return [data[0], data[2]]
    
if __name__ == "__main__":
    input_path = "hdfs://ngocphung-master:9000/BigData/ex-37/input.csv"
    output_path = "hdfs://ngocphung-master:9000/BigData/ex-37/output"
    # Khởi tạo một SparkSession (một ứng dụng Spark)
    spark = SparkSession.builder.appName('Exercise-37').getOrCreate()
    sc = spark.sparkContext
    absolute_path = Path().absolute()

    lines = sc.textFile(input_path)
        # "s1,2016-01-01,20.5"
        # "s2,2016-01-01,30.1"
        # "s1,2016-01-02,60.2"
        # "s2,2016-01-02,20.4"
        # "s1,2016-01-03,55.5"
        # "s2,2016-01-03,52.5"
        
    sensor_temp = lines.map(split_data)
        # ("s1", 20.5), ("s2", 30.1), ("s1", 60.2), ("s2", 20.4), ("s1", 55.5), ("s2", 52.5)
   
    max_temp_by_sensor = sensor_temp.reduceByKey(lambda x,y : x if x > y else y)
        # ("s1", 60.2), ("s2", 52.5)
        
    max_temp_by_sensor.coalesce(1).saveAsTextFile(output_path)
    # Dừng SparkSession để giải phóng tài nguyên
    spark.stop()