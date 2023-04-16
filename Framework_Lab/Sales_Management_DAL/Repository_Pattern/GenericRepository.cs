using Microsoft.EntityFrameworkCore;
using Sales_Management_DAL.Context.Base_Context;
using Sales_Management_DAL.Entities;
using Sales_Management_DAL.Repositories.Interfaces;
using Sales_Management_DAL.Specifications;
using Sales_Management_DAL.Specifications.Interfaces;

namespace Labs_EF.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity
    {
        private readonly SalesContext _context;

        public GenericRepository(SalesContext context) => _context = context;

        public async Task<IEnumerable<TEntity>> Delete_Entity(Guid ID)
        {
            var result = await _context.Set<TEntity>().FirstOrDefaultAsync(x => x.ID == ID);

            if (result is null)
            {
                throw new Exception($"Entity with ID {ID} not found!");
            }

            _context.Set<TEntity>().Remove(result);

            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> Get_all_Information()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity?> Get_information_ID(Guid ID)
        {
            return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.ID == ID);
        }

        public async Task<IEnumerable<TEntity>> Insert_Entity(TEntity entity)
        {
            entity.Created_at = DateTime.Now;
            entity.Updated_at = DateTime.Now;

            await _context.Set<TEntity>().AddAsync(entity);
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> Update_Entity(TEntity entity)
        {
            entity.Updated_at = DateTime.Now;

            try
            {
                var result = await this.Get_information_ID(entity.ID);

                if (result is null)
                {
                    throw new Exception($"Entity with ID {entity.ID} not found!");
                }

                _context.Set<TEntity>().Update(entity);
                return await _context.Set<TEntity>().ToListAsync();
            }
            catch (Exception exception)
            {
                throw new Exception($"Something went wrong...", exception);
            }
        }

        public IEnumerable<TEntity> Find_with_Specifications_Pattern(ISpecifications<TEntity> specifications)
        {
            return Apply_Specifications(specifications);
        }

        private IQueryable<TEntity> Apply_Specifications(ISpecifications<TEntity> specifications)
        {
            return Specifications_Evaluator<TEntity>.Get_all_Information(_context.Set<TEntity>().AsQueryable(), specifications);
        }
    }
}
