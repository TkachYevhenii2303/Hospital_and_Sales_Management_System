using Sales_Management_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sales_Management_BLL.Data_transfers_Results.Response_Results_DTO
{
    public class GET_Customers_Response_DTO : Base_Response_Result<GET_Customers_Response_DTO, Customers>
    {
        [JsonPropertyName("Customer Title:")]
        public string Customers_title { get; set; } = string.Empty;

        [JsonPropertyName("Customer Email:")]
        public string Customers_email { get; set; } = string.Empty;
    }
}
