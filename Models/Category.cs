using System;
using System.Collections.Generic;

namespace PRN_PRJ.Models
{
    public partial class Category
    {
        public Category()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
