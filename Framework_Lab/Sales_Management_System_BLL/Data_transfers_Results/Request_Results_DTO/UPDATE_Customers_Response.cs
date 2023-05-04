using Sales_Management_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_BLL.Data_transfers_Results.Request_Results_DTO
{
    public class UPDATE_Customers_Response : Base_Request_Result<UPDATE_Customers_Response, Customers>
    {
        public Guid Id { get; set; }

        public string Customers_title { get; set; } = string.Empty;

        public string Customers_email { get; set; } = string.Empty;
    }
}
