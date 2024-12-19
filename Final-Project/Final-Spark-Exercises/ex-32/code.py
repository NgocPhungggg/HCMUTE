import sys
import os
from pathlib import Path
from pyspark.sql import SparkSession  # Import SparkSession
if __name__ == "__main__":
    # Đường dẫn file đầu vào
    input_path = "hdfs://ngocphung-master:9000/spark/ex-32/input.txt"
    output_path = "hdfs://ngocphung-master:9000/spark/ex-32/output"
    spark = SparkSession.builder.appName("Spark Exercise #32").getOrCreate()

    
    readings_rdd = spark.sparkContext.textFile(input_path)
        # "s1,2016-01-01,20.5"
        # "s2,2016-01-02,30.1"
        # "s1,2016-01-01,60.2"
        # "s2,2016-01-02,20.4"
        # "s1,2016-01-03,55.5"
        # "s2,2016-01-03,52.5"

    pm10_values_rdd = readings_rdd.map(lambda line: float(line.split(",")[2]))
        # 20.5
        # 30.1
        # 60.2
        # 20.4
        # 55.5
        # 52.5

    max_pm10_value = pm10_values_rdd.reduce(lambda value1, value2: max(value1, value2))
        # 60.2

    max_pm10_rdd = spark.sparkContext.parallelize([max_pm10_value])
    max_pm10_rdd.coalesce(1).saveAsTextFile(output_path)

    # Đóng SparkSession
    spark.stop()
