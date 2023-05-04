using Sales_Management_DAL.Context.Base_Context;
using Sales_Management_DAL.Repositories.Interfaces;
using Sales_Management_DAL.Repository_Pattern;
using Sales_Management_DAL.Repository_Pattern.Interfaces;

namespace Sales_Management_DAL.Repositories
{
    public class Unit_of_Work : IUnit_of_Work
    {
        private readonly SalesContext _context;

        public Unit_of_Work(SalesContext context)
        {
            _context = context;
            this.Customers_Repository = new CustomersRepository(_context);
            this.Products_Repository = new ProductsRepository(_context);    
            this.Stores_Repository = new StoresRepository(_context);
            this.Sales_Repository = new SalesRepository(_context);
        }

        public ICustomersRepository Customers_Repository { get; private set; }

        public IProductsRepository Products_Repository { get; private set; }

        public IStoresRepository Stores_Repository { get; private set; }

        public ISalesRepository Sales_Repository { get; private set; }

        public int Complete() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
