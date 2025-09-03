use("LibraryDB");
db.createCollection("account");
db.account.createIndex({ username: 1 }, { unique: true });
db.createCollection("staff");
db.staff.createIndex({ username: 1 }, { unique: true });
db.createCollection("reader");
db.reader.createIndex({ username: 1 }, { unique: true });

db.createCollection("author");
db.author.createIndex({ authorId: 1 }, { unique: true });
db.author.createIndex({ authorName: 1 }, { unique: true });
db.createCollection("book");
db.book.createIndex({ bookId: 1 }, { unique: true });
db.createCollection("category");
db.category.createIndex({ categoryId: 1 }, { unique: true });


db.createCollection("loan");
db.loan.createIndex({ readerId: 1 })
db.loan.createIndex({ status: 1 })
db.loan.createIndex({ bookId: 1 })
db.createCollection("transaction");
db.transaction.createIndex({ loanId:     1 })
db.transaction.createIndex({ employeeId: 1 })


//Thống kế sách theo tên tác giảgiả
use("LibraryDB");
db.book.aggregate([
  {
    $group: {
      _id: "$authorName",
      totalBooks: { $sum: 1 }
    }
  },
  {
    $sort: { totalBooks: -1 }
  }
])
//Thống kế sách theo thể loại sách
use("LibraryDB");
db.book.aggregate([
  {
    $group: {
      _id: "$categoryName",
      totalBooks: { $sum: 1 }
    }
  },
  {
    $sort: { totalBooks: -1 }
  }
])
//Thống kế mượn theo năm
use("LibraryDB");
db.transaction.aggregate([
  {
    $group: {
      _id: { $year: "$transactionDate" },
      totalTransactions: { $sum: 1 }
    }
  },
  { $sort: { _id: 1 } }
])
//Thống kế lượng thanh toán theo năm
db.transaction.aggregate([
  { $match: { type: "Payment" } },
  {
    $group: {
      _id: { $year: "$transactionDate" },
      totalPaid: { $sum: "$amount" }
    }
  },
  { $sort: { "_id": 1 } }
])
//Thống kế tình trạng sách hiện tại
db.loan.aggregate([
  {
    $group: {
      _id: "$status",
      total: { $sum: 1 }
    }
  }
])
