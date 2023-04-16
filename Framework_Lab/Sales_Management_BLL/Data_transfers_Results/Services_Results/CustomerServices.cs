using Mapster;
using MapsterMapper;
using Sales_Management_BLL.Data_transfers_Results.Request_Results_DTO;
using Sales_Management_BLL.Data_transfers_Results.Response_Results_DTO;
using Sales_Management_DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_BLL.Data_transfers_Results.Services_Results
{
    public class CustomerServices : ICustomersServices
    {
        private readonly IUnit_of_Work _unit_Of_Work;

        public CustomerServices(IUnit_of_Work unit_Of_Work)
        {
            _unit_Of_Work = unit_Of_Work;
        }

        public Task<IEnumerable<GET_Customers_Response_DTO>> Delete_Customers(Guid ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GET_Customers_Response_DTO>> Get_all_Customers()
        {
            var result = _unit_Of_Work.Customers_Repository.Get_all_Information().Adapt<GET_Customers_Response_DTO[]>();

             _unit_Of_Work.Complete();
            
            return result;
        }

        public Task<GET_Customers_Response_DTO> Get_Customer_ID(Guid ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GET_Customers_Response_DTO>> Insert_Customers(INSERT_Customers_Response_DTO doctors)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GET_Customers_Response_DTO>> Update_Customers(INSERT_Customers_Response_DTO doctors)
        {
            throw new NotImplementedException();
        }
    }
}
