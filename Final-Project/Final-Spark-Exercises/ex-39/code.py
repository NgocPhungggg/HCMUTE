import sys
import os
from pathlib import Path  # Thư viện để lấy đường dẫn thư mục hiện tại
from pyspark.sql import SparkSession  # Import SparkSession từ PySpark
from operator import add  # Import hàm add để hỗ trợ phép cộng

def split_data(line):
    """
    Split each line into columns
    """
    data = str.split(line, ',')  # Tách dòng dữ liệu thành danh sách dựa trên dấu phẩy
    return [data[0], data[1]]  # Trả về sensorId và date

def filter_data(line):
    """
    Just a filter
    """
    temp = float(str.split(line, ',')[2])  # Chuyển cột nhiệt độ (cột 3) thành kiểu float
    return temp > 50  # Chỉ giữ lại các dòng có nhiệt độ lớn hơn 50

if __name__ == "__main__":
    input_path = "hdfs://ngocphung-master:9000/spark/ex-39/input.csv"
    output_path = "hdfs://ngocphung-master:9000/spark/ex-39/output"
    # Khởi tạo một SparkSession (một ứng dụng Spark)
    spark = SparkSession.builder.appName('Exercise-34').getOrCreate()
    sc = spark.sparkContext
    absolute_path = Path().absolute()

    lines = sc.textFile(input_path)
        # "s1,2016-01-01,20.5"
        # "s2,2016-01-01,30.1"
        # "s1,2016-01-02,60.2"
        # "s2,2016-01-02,20.4"
        # "s1,2016-01-03,55.5"
        # "s2,2016-01-03,52.5"

    lines_above = lines.filter(filter_data)
        # "s1,2016-01-02,60.2"
        # "s1,2016-01-03,55.5"
        # "s2,2016-01-03,52.5"

    lines_above = lines_above.map(split_data)
        # "s1,2016-01-02"
        # "s1,2016-01-03"
        # "s2,2016-01-03"

    lines_above_by_key = lines_above.groupByKey().mapValues(list)
        # ('s1', ['2016-01-02', '2016-01-03'])
        # ('s2', ['2016-01-03'])

    # Gộp tất cả dữ liệu thành một file duy nhất và lưu kết quả vào thư mục đầu ra
    lines_above_by_key.coalesce(1).saveAsTextFile(output_path)

    # Dừng SparkSession để giải phóng tài nguyên
    spark.stop()
