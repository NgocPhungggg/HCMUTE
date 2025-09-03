import sys
import os
from pathlib import Path

from pyspark.sql import SparkSession  # Import SparkSession để làm việc với Spark

if __name__ == "__main__":
    spark = SparkSession.builder.ap
    input_path = "hdfs://ngocphung-master:9000/BigData/ex-30/input.txt"
    output_path = "hdfs://ngocphung-master:9000/BigData/ex-30/output"
    pName('Exercise-30').getOrCreate()
    absolute_path = Path().absolute()

    lines = spark.read.text(input_path).rdd.map(lambda x: x[0])
    # "66.249.69.97 --[24/Sep/2014:22:25:44  +0000]  \"GET http://www.google.com/bot.html\""
    # "66.249.69.97 --[24/Sep/2014:22:26:44  +0000]  \"GET  http://www.google.com/how.html\""
    # "66.249.69.97 --[24/Sep/2014:22:28:44 +0000] \"GET http://dbdmg.polito.it/course.html\""
    # "71.19.157.179 --[24/Sep/2014:22:30:12  +0000]  \"GET http://www.google.com/faq.html\""
    # "66.249.69.97 --[24/Sep/2014:31:28:44 +0000] \"GET http://dbdmg.polito.it/thesis.html\""

    lines_w_google = lines.filter(lambda x: 'google' in x)
    # "66.249.69.97 --[24/Sep/2014:22:25:44  +0000]  \"GET http://www.google.com/bot.html\""
    # "66.249.69.97 --[24/Sep/2014:22:26:44  +0000]  \"GET  http://www.google.com/how.html\""
    # "71.19.157.179 --[24/Sep/2014:22:30:12  +0000]  \"GET http://www.google.com/faq.html\""

    lines_w_google.coalesce(1).saveAsTextFile(output_path)
    
    # Dừng SparkSession để giải phóng tài nguyên
    spark.stop()