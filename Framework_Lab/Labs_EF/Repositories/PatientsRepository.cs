using Labs_EF.DataContext;
using Labs_EF.Entities;
using Labs_EF.Repositories.Interfaces;

namespace Labs_EF.Repositories
{
    public class PatientsRepository : GenericRepository<Patients>, IPatientsRepository
    {
        public PatientsRepository(HospitalContext context) : base(context)
        {
        }
    }
}
