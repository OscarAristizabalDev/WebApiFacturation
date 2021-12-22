using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class AccountDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int AccountId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }

        public Account Account { get; set; }
        public Product Product { get; set; }
    }
}
