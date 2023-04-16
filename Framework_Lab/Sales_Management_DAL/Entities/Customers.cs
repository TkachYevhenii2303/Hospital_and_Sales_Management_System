using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_DAL.Entities
{
    public class Customers : Entity
    {
        public string Customers_title { get; set; } = string.Empty;

        public string Customers_email { get; set; } = string.Empty;

        public ICollection<Sales> Sales { get; set; } = null!;
    }
}
