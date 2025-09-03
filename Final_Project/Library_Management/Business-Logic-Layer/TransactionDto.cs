using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class TransactionDto
    {
        public string LoanId { get; set; }
        public string ReaderUsername { get; set; }
        public string BookId { get; set; }
        public string StaffUsername { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
    }

}

