import org.apache.spark.SparkContext
import org.apache.spark.SparkConf

val conf = new SparkConf().setAppName("FriendCount").setMaster("local")
val sc = new SparkContext(conf)

val text = sc.textFile("D:/BDE (Big Data Essential)/Final Project/Spark_Scala/Input/FriendCount.txt")
val counts = text.flatMap(line => line.split(" ")).map(word => (word, 1)).reduceByKey(_ + _)
counts.saveAsTextFile("D:/BDE (Big Data Essential)/Final Project/Spark_Scala/Output/FriendCount")

sc.stop()
