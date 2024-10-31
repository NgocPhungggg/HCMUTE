import org.apache.spark.SparkContext
import org.apache.spark.SparkConf

val conf = new SparkConf().setAppName("WordLength").setMaster("local")
val sc = new SparkContext(conf)

val text = sc.textFile("D:/BDE (Big Data Essential)/Final Project/Spark_Scala/Input/WordLength.txt")

val wordLengths = text.flatMap(line => {
    val words = line.split(" ")
    words.map(word => {
        val length = word.length
        val category = length match {
            case 1 => "tiny"
            case x if x >= 1 && x <= 4 => "small"
            case x if x >= 5 && x <= 9 => "medium"
            case _ => "big"
        }
        (word, category)
    })
})
wordLengths.saveAsTextFile("D:/BDE (Big Data Essential)/Final Project/Spark_Scala/Output/WordLength")

sc.stop()
