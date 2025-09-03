from pyspark import SparkConf, SparkContext

# Khởi tạo SparkConf
conf = SparkConf().setMaster("spark://192.168.1.133:7077").setAppName("WordCount")

# Khởi tạo SparkContext
sc = SparkContext(conf=conf)

# Đọc dữ liệu từ một tập tin văn bản
lines = sc.textFile("D:/BDE (Big Data Essential)/Final Project/Spark_Python/Input/WordCount.txt")

# Chia các dòng thành các từ và tạo RDD mới
words = lines.flatMap(lambda line: line.split(" "))

# Ánh xạ các từ thành cặp (word, 1) để đếm
word_counts = words.map(lambda word: (word, 1))

# Gom các cặp theo từ và tính tổng số lần xuất hiện của mỗi từ
word_counts = word_counts.reduceByKey(lambda x, y: x + y)

# Lưu kết quả ra file văn bản
word_counts.saveAsTextFile("D:/BDE (Big Data Essential)/Final Project/Spark_Python/Output/WordCount")

# Dừng SparkContext
sc.stop()