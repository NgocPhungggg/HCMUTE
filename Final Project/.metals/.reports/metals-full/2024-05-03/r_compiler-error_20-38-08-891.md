file:///D:/BDE%20(Big%20Data%20Essential)/Final%20Project/Spark_Scala/WordLength.scala
### dotty.tools.dotc.core.TypeError$$anon$1: Toplevel definition counts is defined in
  D:/BDE (Big Data Essential)/Final Project/Spark_Scala/WordCount.scala
and also in
  D:/BDE (Big Data Essential)/Final Project/Spark_Scala/FriendCount.scala
One of these files should be removed from the classpath.

occurred in the presentation compiler.

presentation compiler configuration:
Scala version: 3.3.3
Classpath:
<HOME>\AppData\Local\Coursier\cache\v1\https\repo1.maven.org\maven2\org\scala-lang\scala3-library_3\3.3.3\scala3-library_3-3.3.3.jar [exists ], <HOME>\AppData\Local\Coursier\cache\v1\https\repo1.maven.org\maven2\org\scala-lang\scala-library\2.13.12\scala-library-2.13.12.jar [exists ]
Options:



action parameters:
offset: 272
uri: file:///D:/BDE%20(Big%20Data%20Essential)/Final%20Project/Spark_Scala/WordLength.scala
text:
```scala
import org.apache.spark.SparkContext
import org.apache.spark.SparkConf

val conf = new SparkConf().setAppName("WordLength").setMaster("local")
val sc = new SparkContext(conf)

val text = sc.textFile("D:/BDE (Big Data Essential)/Final Project/Spark_Scala/Input/WordLe@@ngth.txt")

val wordLengths = text
  .flatMap(line => line.split(" "))
  .map(word => {
    val length = word.length
    val category = length match {
      case 1 => "tiny"
      case x if x >= 1 && x <= 4 => "small"
      case x if x >= 5 && x <= 9 => "medium"
      case _ => "big"
    }
    (word, category)
  })

wordLengths.saveAsTextFile("D:/BDE (Big Data Essential)/Final Project/Spark_Scala/Output/WordLength")

sc.stop()

```



#### Error stacktrace:

```

```
#### Short summary: 

dotty.tools.dotc.core.TypeError$$anon$1: Toplevel definition counts is defined in
  D:/BDE (Big Data Essential)/Final Project/Spark_Scala/WordCount.scala
and also in
  D:/BDE (Big Data Essential)/Final Project/Spark_Scala/FriendCount.scala
One of these files should be removed from the classpath.