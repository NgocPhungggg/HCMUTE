import sys
import os
from pathlib import Path
from pyspark.sql import SparkSession  # Import SparkSession

if __name__ == "__main__":
    input_path = "hdfs://ngocphung-master:9000/BigData/ex-31/input.txt"
    output_path = "hdfs://ngocphung-master:9000/BigData/ex-31/output"
    spark = SparkSession.builder.appName("Exercise-31").master("yarn").getOrCreate()
    absolute_path = Path().absolute()

    log_rdd = spark.sparkContext.textFile(input_path)
        # 66.249.69.97 --[24/Sep/2014:22:25:44  +0000]  "GET http://www.google.com/bot.html"
        # 66.249.69.97 --[24/Sep/2014:22:26:44  +0000]  "GET  http://www.google.com/how.html"
        # 66.249.69.97 --[24/Sep/2014:22:28:44 +0000] "GET http://dbdmg.polito.it/course.html"
        # 71.19.157.179 --[24/Sep/2014:22:30:12  +0000]  "GET http://www.google.com/faq.html"
        # 66.249.69.97 --[24/Sep/2014:31:28:44 +0000] "GET http://dbdmg.polito.it/thesis.html"

    google_rdd = log_rdd.filter(lambda log_line: "google" in log_line.lower())
        # "66.249.69.97 --[24/Sep/2014:22:25:44  +0000]  \"GET http://www.google.com/bot.html\""
        # "66.249.69.97 --[24/Sep/2014:22:26:44  +0000]  \"GET  http://www.google.com/how.html\""
        # "71.19.157.179 --[24/Sep/2014:22:30:12  +0000]  \"GET http://www.google.com/faq.html\""

    ip_rdd = google_rdd.map(lambda log_line: log_line.split(" ")[0])
        # "66.249.69.97"
        # "66.249.69.97"
        # "71.19.157.179"

    ip_distinct_rdd = ip_rdd.distinct()
        # "66.249.69.97"
        # "71.19.157.179"
        
    ip_distinct_rdd.coalesce(1).saveAsTextFile(output_path)
    spark.stop()
