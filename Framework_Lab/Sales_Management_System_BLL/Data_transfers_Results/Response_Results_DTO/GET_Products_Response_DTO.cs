using Sales_Management_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_BLL.Data_transfers_Results.Response_Results_DTO
{
    public class GET_Products_Response_DTO : Base_Response_Result<GET_Products_Response_DTO, Products>
    {
        public string Products_title { get; set; } = string.Empty;

        public int Products_count { get; set; } = 0;
    }
}
