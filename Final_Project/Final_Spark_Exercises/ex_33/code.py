import sys
import os
from pathlib import Path
from pyspark.sql import SparkSession
def split_data(line):
    """
    Return the temperature of each line
    """
    data = str.split(line, ',')
    return float(data[2])
if __name__ == "__main__":
    # Đường dẫn file đầu vào
    input_path = "hdfs://ngocphung-master:9000/spark/ex-33/input.csv"
    output_path = "hdfs://ngocphung-master:9000/spark/ex-33/output"
    # Khởi tạo một SparkSession (một ứng dụng Spark)
    spark = SparkSession.builder.appName('Exercise-33').getOrCreate()
    sc = spark.sparkContext
    absolute_path = Path().absolute()
    # Đọc file đầu vào từ HDFS, mỗi dòng trong file là một phần tử trong RDD
    # VD: ["s1,2016-01-01,20.5","s2,2016-01-01,30.1"]
    lines = sc.textFile(input_path)
    # Lấy ra 3 giá trị nhiệt độ lớn nhất từ RDD
    # Sử dụng hàm top(3) để trả về danh sách chứa 3 phần tử lớn nhất
    # [20.5, 30.1, 60.2, 20.4, 60.2, 52.5]
    temperatures = lines.map(split_data)
    # [60.2, 60.2, 52.5]
    top_3 = temperatures.top(3)
    # Chuyển danh sách top_3 thành một RDD để có thể lưu vào HDFS
    top_3_rdd = sc.parallelize(top_3)
    # Lưu kết quả vào thư mục đầu ra
    top_3_rdd.coalesce(1).saveAsTextFile(output_path)
    spark.stop()