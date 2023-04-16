using Labs_EF.Entities;

namespace Labs_EF.Repositories.Interfaces
{
    public interface IDoctrosRepository : IGenericRepository<Doctors>
    {
        public Task<IEnumerable<string>> Get_all_Specialities();
    }
}
