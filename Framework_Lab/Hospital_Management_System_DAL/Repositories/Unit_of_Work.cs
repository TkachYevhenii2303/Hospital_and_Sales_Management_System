using Labs_EF.DataContext;
using Labs_EF.Repositories.Interfaces;

namespace Labs_EF.Repositories
{
    public class Unit_of_Work : IUnit_of_Work
    {
        private readonly HospitalContext _context;

        public Unit_of_Work(HospitalContext context)
        {
            _context = context;
            this.Doctros_Repository = new DoctorsRepository(_context);
        }

        public IDoctrosRepository Doctros_Repository { get; private set; }

        public int Complete() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
