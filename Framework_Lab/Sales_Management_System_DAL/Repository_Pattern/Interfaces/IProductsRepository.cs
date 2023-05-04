using Sales_Management_DAL.Entities;
using Sales_Management_DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_DAL.Repository_Pattern.Interfaces
{
    public interface IProductsRepository : IGenericRepository<Products>
    {
    }
}
