using Pizza_System_BLL.Context;
using Pizza_System_BLL.Entities;
using Pizza_System_BLL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_System_BLL.Repositories
{
    public class SauceRepository : GenericRepository<Sauce>, ISauceRepository
    {
        private readonly PizzaContext _context;

        public SauceRepository(PizzaContext context) : base(context)
        {
            _context = context;
        }
    }
}
