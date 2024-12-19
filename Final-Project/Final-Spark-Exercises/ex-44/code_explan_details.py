from pyspark import SparkContext, SparkConf

if __name__ == "__main__":
    # Nhận các tham số đầu vào
    inputPathWatched = "hdfs://ngocphung-master:9000/BigData/ex-44/watchedmovies.txt"
    inputPathPreferences = "hdfs://ngocphung-master:9000/BigData/ex-44/preferences.txt"
    inputPathMovies = "hdfs://ngocphung-master:9000/BigData/ex-44/movies.txt"
    outputPath = "hdfs://ngocphung-master:9000/BigData/ex-44/output"
    threshold = 0.3 
    conf = SparkConf().setAppName("Exercise-44")
    sc = SparkContext(conf=conf)

    # Đọc dữ liệu từ file watchedmovies.txt
    # Mục đích: Tạo RDD từ file watchedmovies.txt
    watchedRDD = sc.textFile(inputPathWatched)
        # user1,movie1,201606061500,201606061650
        # user1,movie3,201606061800,201606061834
        # user1,movie4,201609061500,201609061605
        # user1,movie5,201610061100,201610061450
        # user2,movie6,201610081800,201610081845
        # user2,movie3,201610091800,201610091834
        # user2,movie4,201611051100,201611051105

    # Map dữ liệu từ file watchedmovies.txt thành cặp (movieID, userID)  
    # Mục đích: Lấy movieID làm key và userID làm value  
    movieUserPairRDD = watchedRDD.map(lambda line: (line.split(",")[1], line.split(",")[0]))
        # (movie1, user1)
        # (movie3, user1)
        # (movie4, user1)
        # (movie5, user1)
        # (movie6, user2)
        # (movie3, user2)
        # (movie4, user2)

    # Đọc dữ liệu từ file movies.txt
    moviesRDD = sc.textFile(inputPathMovies)
        # movie1,Toy Story (1995),Animation
        # movie2,Jumanji (1995),Adventure
        # movie3,Grumpier Old Men (1995),Comedy
        # movie4,Waiting to Exhale (1995),Comedy
        # movie5,Father of the Bride Part II (1995),Comedy
        # movie6,Heat (1995),Action
        # movie7,Sabrina (1995),Comedy
        # movie8,Tom and Huck (1995),Adventure
        # movie9,Sudden Death (1995),Action
        # movie10,GoldenEye (1995),Action

    # Map dữ liệu từ file movies.txt thành cặp (movieID, genre)
    # Mục đích: Lấy movieID làm key và genre làm value   
    movieGenrePairRDD = moviesRDD.map(lambda line: (line.split(",")[0], line.split(",")[2]))
        # (movie1, Animation)
        # (movie2, Adventure)
        # (movie3, Comedy)
        # (movie4, Comedy)
        # (movie5, Comedy)
        # (movie6, Action)
        # (movie7, Comedy)
        # (movie8, Adventure)
        # (movie9, Action)
        # (movie10, Action)

    # Thực hiện join giữa movieUserPairRDD và movieGenrePairRDD
    joinWatchedGenreRDD = movieUserPairRDD.join(movieGenrePairRDD)
        # (movie1, (user1, Animation))
        # (movie3, (user1, Comedy))
        # (movie4, (user1, Comedy))
        # (movie5, (user1, Comedy))
        # (movie6, (user2, Action))
        # (movie3, (user2, Comedy))
        # (movie4, (user2, Comedy))

    # Map dữ liệu thành cặp (userID, genre)
    # Mục đích: Lấy userID làm key và genre làm value.
    usersWatchedGenresRDD = joinWatchedGenreRDD.map(lambda userMovie: (userMovie[1][0], userMovie[1][1]))
        # (user1, Animation)
        # (user1, Comedy)
        # (user1, Comedy)
        # (user1, Comedy)
        # (user2, Action)
        # (user2, Comedy)
        # (user2, Comedy)
    preferencesRDD = sc.textFile(inputPathPreferences)


    # Map dữ liệu thành cặp (userID, likedGenre)
    # Mục đích: Lấy userID làm key và likedGenre làm value.
    userLikedGenresRDD = preferencesRDD.map(lambda line: (line.split(",")[0], line.split(",")[1]))
        # (user1, Animation)
        # (user1, Comedy)
        # (user2, Action)

    # Gom nhóm các thể loại đã xem và yêu thích
    userWatchedLikedGenres = usersWatchedGenresRDD.cogroup(userLikedGenresRDD)
        # (user1, ([Animation, Comedy, Comedy, Comedy], [Animation, Comedy]))
        # (user2, ([Action, Comedy, Comedy], [Action]))

    # Mục đích: Xác định người dùng xem phim mà thể loại không yêu thích.
    misleadingUsersListsRDD = userWatchedLikedGenres.filter(
        lambda userGenres: (
            lambda likedGenres, watchedGenres: (
        # Đếm số lượng thể loại phim đã xem (watchedGenres) 
        # nhưng không nằm trong danh sách thể loại yêu thích (likedGenres)
                sum(1 for genre in watchedGenres if genre not in likedGenres) >
            #Tổng số lượng phim đã xem * 30%
                misleading * len(list(watchedGenres))
            )
        )(set(userGenres[1][1]), userGenres[1][0])
    )
            #(user2, ([Action, Comedy, Comedy], [Action]))

    misleadingUsersRDD = misleadingUsersListsRDD.keys()

    misleadingUsersRDD.coalesce(1).saveAsTextFile(outputPath)

    # Dừng SparkContext
    sc.stop()
