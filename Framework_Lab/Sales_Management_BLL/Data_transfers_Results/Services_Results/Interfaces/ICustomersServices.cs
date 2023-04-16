using Sales_Management_BLL.Data_transfers_Results.Request_Results_DTO;
using Sales_Management_BLL.Data_transfers_Results.Response_Results_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_BLL.Data_transfers_Results.Services_Results
{
    public interface ICustomersServices
    {
        public Task<IEnumerable<GET_Customers_Response_DTO>> Get_all_Customers();

        public Task<GET_Customers_Response_DTO> Get_Customer_ID(Guid ID);

        public Task<IEnumerable<GET_Customers_Response_DTO>> Insert_Customers(INSERT_Customers_Response_DTO doctors);

        public Task<IEnumerable<GET_Customers_Response_DTO>> Update_Customers(INSERT_Customers_Response_DTO doctors);

        public Task<IEnumerable<GET_Customers_Response_DTO>> Delete_Customers(Guid ID);
    }
}
