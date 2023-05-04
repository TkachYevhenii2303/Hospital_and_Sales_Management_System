using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_DAL.Entities
{
    public class Stores : Entity
    {
        public string Stores_title { get; set; } = string.Empty;

        public ICollection<Sales> Sales { get; set; } = null!;
    }
}
