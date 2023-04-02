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

        public async Task<ServicesResponse<IEnumerable<TEntity>>> Get_all_Information()
        {
            var services_Response = new ServicesResponse<IEnumerable<TEntity>>();
            var result = await _context.Set<TEntity>().ToListAsync();

            services_Response.Entity = result.Select(x => x).ToList();  
            return services_Response;
        }

        public async Task<ServicesResponse<TEntity>?> Get_information_ID(Guid ID)
        {
            var services_Response = new ServicesResponse<TEntity>();
            var result = _context.Set<TEntity>().FirstOrDefault(x => x.Id == ID);

            services_Response.Entity = result;
            return services_Response;
        }
    }
}
