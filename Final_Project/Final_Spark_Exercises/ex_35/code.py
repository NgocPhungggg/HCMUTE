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
    return data[2]   

if __name__ == "__main__":
    input_path = "hdfs://ngocphung-master:9000/BigData/ex-35/input.csv"
    output_path = "hdfs://ngocphung-master:9000/BigData/ex-35/output"
    spark = SparkSession.builder.appName('Exercise-35').getOrCreate()
    sc = spark.sparkContext
    absolute_path = Path().absolute()

    lines = sc.textFile(input_path)
        # s1,2016-01-01,20.5
        # s2,2016-01-01,30.1
        # s1,2016-01-02,60.2
        # s2,2016-01-02,20.4
        # s1,2016-01-03,60.2
        # s2,2016-01-03,52.5    

    # Mục đích: Lấy giá trị lớn nhất từ danh sách nhiệt độ.
    max_temp = lines.map(split_data).top(1)[0]
        # 20.5, 30.1, 60.2, 20.4, 60.2, 52.5
        # 60.2

    # Mục đích: Lọc ra các dòng có nhiệt độ bằng với max_temp.
    max_temp_dates = (lines
                    .filter(lambda x: split_data(x) == max_temp)  # Lọc các dòng có nhiệt độ bằng `max_temp`
                    .map(lambda x: str.split(x, ',')[1]))  # Lấy cột ngày (cột thứ 2) từ các dòng đã lọc
    # ['2016-01-02', '2016-01-03']

    max_temp_dates.coalesce(1).saveAsTextFile(output_path)
    # Dừng SparkSession để giải phóng tài nguyên
    spark.stop()