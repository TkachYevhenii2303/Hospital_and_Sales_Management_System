using Pizza_System_BLL.Context;
using Pizza_System_BLL.Repositories;
using Pizza_System_BLL.Repositories.Interfaces;

namespace Labs_EF.Repositories
{
    public class Unit_of_Work : IUnit_of_Work
    {
        private readonly PizzaContext _context;

        public Unit_of_Work(PizzaContext context)
        {
            _context = context;
            _Pizza_Repository = new PizzaRepository(_context);
            _Sause_Repository = new SauceRepository(_context);
            _Toppings_Repository = new ToppingsRepository(_context);    
        }

        public IPizzaRepository _Pizza_Repository { get; set; }
        
        public ISauceRepository _Sause_Repository { get; set; }

        public IToppingsRepository _Toppings_Repository { get; set; }

        public int Complete() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
