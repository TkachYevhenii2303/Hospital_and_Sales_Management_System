using Microsoft.EntityFrameworkCore;
using Students_System.Context;
using Students_System.Entities;
using Students_System.Repository.Interfaces;
using System.Linq.Expressions;

namespace Students_System.Repository
{
    // Implementation for all methods from IGenericRepository
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity
    {
        private readonly Students_System_Context _context;

        public IQueryable<TEntity> Entities => _context.Set<TEntity>(); 

        public GenericRepository(Students_System_Context context)
        {
            _context = context;
        }

        public IQueryable<TEntity> Get_all_Information(Expression<Func<TEntity, bool>>? expression = null)
        {
            var result = _context.Set<TEntity>().AsNoTracking();

            if (expression != null) { result = result.Where(expression); }

            return result;
        }

        public async Task<TEntity> Get_Entity_ID(Guid Id)
        {
            return await _context.Set<TEntity>().FirstAsync(x => x.Id == Id);
        }
    }
}
