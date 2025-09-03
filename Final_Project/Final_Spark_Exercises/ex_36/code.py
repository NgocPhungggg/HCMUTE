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
    return float(data[2])

# Điểm bắt đầu của chương trình
if __name__ == "__main__":
    input_path = "hdfs://ngocphung-master:9000/BigData/ex-36/input.csv"
    output_path = "hdfs://ngocphung-master:9000/BigData/ex-36/output"

    spark = SparkSession.builder.appName('Exercise-36').getOrCreate() 
    sc = spark.sparkContext
    current_dir = os.path.dirname(os.path.abspath(__file__))

    lines = sc.textFile(input_path)
        # "s1,2016-01-01,20.5"
        # "s2,2016-01-01,30.1"
        # "s1,2016-01-02,60.2"
        # "s2,2016-01-02,20.4"
        # "s1,2016-01-03,55.5"
        # "s2,2016-01-03,52.5"
        
    mean_temp = lines.map(split_data).mean() 
        # map(split_data) --> 20.5, 30.1, 60.2, 20.4, 55.5, 52.5
        # mean() --> (20.5 + 30.1 + 60.2 + 20.4 + 55.5 + 52.5) / 6 = 38.47
        
    # đảm bảo rằng giá trị mean_temp sẽ được làm tròn đến 2 chữ số thập phân.
    result_rdd = sc.parallelize(["%2.2f" % mean_temp])  
        # ["38.47"]
    result_rdd.coalesce(1).saveAsTextFile(output_path)
    spark.stop() 

