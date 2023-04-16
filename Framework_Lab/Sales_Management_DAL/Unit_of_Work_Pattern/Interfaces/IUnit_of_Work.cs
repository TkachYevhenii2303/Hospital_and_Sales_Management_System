using Sales_Management_DAL.Repository_Pattern.Interfaces;

namespace Sales_Management_DAL.Repositories.Interfaces
{
    public interface IUnit_of_Work : IDisposable
    {
        public ICustomersRepository Customers_Repository { get; }

        public IProductsRepository Products_Repository { get; } 
        
        public IStoresRepository Stores_Repository { get; } 

        public ISalesRepository Sales_Repository { get; }   
        
        public int Complete();
    }
}
