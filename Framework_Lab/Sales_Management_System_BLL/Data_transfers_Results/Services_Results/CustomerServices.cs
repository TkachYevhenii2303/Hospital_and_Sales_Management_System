using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Sales_Management_BLL.Data_transfers_Results.Request_Results_DTO;
using Sales_Management_BLL.Data_transfers_Results.Response_Results_DTO;
using Sales_Management_DAL.Entities;
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
            var customers = await _unit_Of_Work.Customers_Repository.Get_all_Information();
            var result = customers.Adapt<GET_Customers_Response_DTO[]>();
            
            return result;
        }

        public async Task<GET_Customers_Response_DTO> Get_Customer_ID(Guid ID)
        {
            var customer = await _unit_Of_Work.Customers_Repository.Get_information_ID(ID);

            if (customer is null)
            {
                throw new ArgumentNullException($"The customers with ID: {ID} is null!");
            }

            var result = customer.Adapt<GET_Customers_Response_DTO>();

            return result;
        }

        public async Task<IEnumerable<GET_Customers_Response_DTO>> Insert_Customers(INSERT_Customers_Response_DTO customer_transfer)
        {
            var customers = await _unit_Of_Work.Customers_Repository.Insert_Entity(customer_transfer.Entity_to());
            
            _unit_Of_Work.Complete();

            var result = customers.Adapt<GET_Customers_Response_DTO[]>();

            return result;
        }

        public async Task<IEnumerable<GET_Customers_Response_DTO>> Update_Customers(UPDATE_Customers_Response customer_transfer)
        {
            var customers = await _unit_Of_Work.Customers_Repository.Update_Entity(customer_transfer.Entity_to());

            _unit_Of_Work.Complete();

            var result = customers.Adapt<GET_Customers_Response_DTO[]>();

            return result;
        }
    }
}
