using Labs_EF.DataContext;
using Labs_EF.Entities;
using Labs_EF.Repositories.Interfaces;
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

        public async Task<ServicesResponse<IEnumerable<TEntity>>> Get_all_Information()
        {
            var services_Response = new ServicesResponse<IEnumerable<TEntity>>();
            var result = await _context.Set<TEntity>().AsNoTracking().ToListAsync();

            services_Response.Entity = result.Select(x => x).ToList();  
            return services_Response;
        }

        public async Task<ServicesResponse<TEntity>?> Get_information_ID(Guid ID)
        {
            var services_Response = new ServicesResponse<TEntity>();
            var result = await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.ID == ID);

            services_Response.Entity = result;
            return services_Response;
        }

        public async Task<ServicesResponse<IEnumerable<TEntity>>> Insert_Entity(TEntity entity)
        {
            var services_Response = new ServicesResponse<IEnumerable<TEntity>>();
            await _context.Set<TEntity>().AddAsync(entity);

            services_Response.Entity = _context.Set<TEntity>().Select(x => x).ToList();
            return services_Response;
        }
    }
}
