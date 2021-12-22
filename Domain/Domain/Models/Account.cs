using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public DateTime AccountDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<AccountDetail> AccountDetails { get; set; }

    }
}
