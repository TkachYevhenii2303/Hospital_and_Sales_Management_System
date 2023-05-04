using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_DAL.Entities
{
    public class Products : Entity
    {
        public string Products_title { get; set; } = string.Empty;

        public int Products_count { get; set; } = 0;

        public ICollection<Sales> Sales { get; set; } = null!;   
    }
}
