using Labs_EF.DataContext;
using Labs_EF.Entities;
using Labs_EF.Repositories.Interfaces;

namespace Labs_EF.Repositories
{
    public class DoctorsRepository : GenericRepository<Doctors>, IDoctrosRepository
    {
        public DoctorsRepository(HospitalContext context) : base(context)
        {
        }
       
    }
}
