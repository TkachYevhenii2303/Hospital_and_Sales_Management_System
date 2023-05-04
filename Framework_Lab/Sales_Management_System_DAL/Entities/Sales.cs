using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_DAL.Entities
{
    public class Sales : Entity
    {
        public DateTime Date { get; set; }

        public Stores Stores { get; set; } = null!;

        public Guid Stores_ID { get; set; }

        public Customers Customers { get; set; } = null!;   

        public Guid Customers_ID { get; set; }

        public Products Products { get; set; } = null!;

        public Guid Products_ID { get; set; }
    }
}
