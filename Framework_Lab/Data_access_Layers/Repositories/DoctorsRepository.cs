using Data_access_Layers.Specifications;
using Labs_EF.DataContext;
using Labs_EF.Entities;
using Labs_EF.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Labs_EF.Repositories
{
    public class DoctorsRepository : GenericRepository<Doctors>, IDoctrosRepository
    {
        private readonly HospitalContext _context;

        public DoctorsRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<string>> Get_all_Specialities()
        {
            return await _context.Doctors.Select(x => x.Specialty.ToString()).ToListAsync();
        }
    }
}
