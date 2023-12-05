using System;
using System.Collections.Generic;

namespace PRN_PRJ.Models
{
    public partial class User
    {
        public User()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? VerificationCode { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
