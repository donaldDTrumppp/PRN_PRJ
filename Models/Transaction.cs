using System;
using System.Collections.Generic;

namespace PRN_PRJ.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int? UserId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? CategoryId { get; set; }
        public decimal? Amount { get; set; }
        public string? Description { get; set; }
        public string? TransactionType { get; set; }

        public virtual Category? Category { get; set; }
        public virtual User? User { get; set; }
    }
}
