using Microsoft.EntityFrameworkCore;
using Pizza_System_BLL.Context;
using Pizza_System_BLL.Entities;
using Pizza_System_BLL.Repositories.Interfaces;

namespace Pizza_System_BLL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity
    {
        private readonly PizzaContext _context;

        public GenericRepository(PizzaContext context) => _context = context;

        public async Task<IEnumerable<TEntity>> Delete_Entity(Guid ID)
        {
            var result = await _context.Set<TEntity>().FirstOrDefaultAsync(x => x.ID == ID);

            if (result is null)
            {
                throw new Exception($"Entity with ID {ID} not found!");
            }

            _context.Set<TEntity>().Remove(result);

            await _context.SaveChangesAsync();

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
            await _context.Set<TEntity>().AddAsync(entity);
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> Update_Entity(TEntity entity)
        {
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
    }
}
