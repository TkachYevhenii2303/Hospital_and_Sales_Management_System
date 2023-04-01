using Labs_EF.DataContext;
using Labs_EF.Entities;
using Labs_EF.Repositories.Interfaces;
using Labs_EF.Specifications;
using Labs_EF.Specifications.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Labs_EF.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity
    {
        private readonly HospitalContext _context;

        public GenericRepository(HospitalContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> Find_with_Specification_Pattern(ISpecifications<TEntity> specifications = null)
        {
            return SpecificationEvaluator<TEntity>.Get_Query(_context.Set<TEntity>().AsQueryable(), specifications);
        }

        public async Task<IEnumerable<ServicesResponse<TEntity>>> Get_all_Information()
        {
            return await _context.Set<ServicesResponse<TEntity>>().ToListAsync();
        }

        public async Task<ServicesResponse<TEntity>?> Get_information_ID(Guid ID)
        {
            return await _context.Set<ServicesResponse<TEntity>>().FirstOrDefaultAsync(result => result.Entity!.Id == ID);
        }
    }
}
