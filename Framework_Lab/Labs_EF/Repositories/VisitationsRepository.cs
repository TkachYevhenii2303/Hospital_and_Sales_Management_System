using Labs_EF.DataContext;
using Labs_EF.Entities;
using Labs_EF.Repositories.Interfaces;

namespace Labs_EF.Repositories
{
    public class VisitationsRepository : GenericRepository<Visitations>, IVisitationsRepository
    {
        public VisitationsRepository(HospitalContext context) : base(context)
        {
        }
    }
}
