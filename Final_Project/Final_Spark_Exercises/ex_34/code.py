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
    input_path = "hdfs://ngocphung-master:9000/spark/ex-34/input.csv"
    output_path = "hdfs://ngocphung-master:9000/spark/ex-34/output"
    # Khởi tạo một SparkSession (một ứng dụng Spark)
    spark = SparkSession.builder.appName('Exercise-34').getOrCreate() 
    sc = spark.sparkContext
    absolute_path = Path().absolute()

    # Đọc dữ liệu đầu vào từ file CSV
    # VD: ["s1,2016-01-01,20.5","s2,2016-01-01,30.1"]
    lines = sc.textFile(input_path)
    
    # Sử dụng map() để trích xuất nhiệt độ từ mỗi dòng.
    # VD: ["20.5", "30.1"]
    # Dùng top(1) để tìm giá trị lớn nhất (là phần tử đầu tiên trong danh sách kết quả).
    max_temp = lines.map(split_data).top(1)[0]

    # Lọc các dòng có nhiệt độ bằng giá trị lớn nhất
    # 1. Sử dụng filter() để giữ lại các dòng có nhiệt độ bằng `max_temp`.
    max_temp_lines = lines.filter(lambda x: split_data(x) == max_temp)
    
    # Lưu kết quả vào thư mục đầu ra
    max_temp_lines.coalesce(1).saveAsTextFile(output_path)
    spark.stop()