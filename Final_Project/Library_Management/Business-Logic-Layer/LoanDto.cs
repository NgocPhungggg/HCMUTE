using System;

namespace Business_Logic_Layer
{
    public class LoanDto
    {
        public string LoanId { get; set; }
        public string ReaderUsername { get; set; }
        public string BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; }
    }
}

