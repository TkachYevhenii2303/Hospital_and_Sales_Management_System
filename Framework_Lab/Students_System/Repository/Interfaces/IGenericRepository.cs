using Students_System.Entities;
using System.Linq.Expressions;

namespace Students_System.Repository.Interfaces
{
    // Creating the Generic Repository Pattern using IQueryable and Expression<Func<TEntity, bool>>
    // I want to create the basic CRUD Operation
    public interface IGenericRepository<TEntity> where TEntity : Entity
    {
        public IQueryable<TEntity> Get_all_Information(Expression<Func<TEntity, bool>>? expression = null);

        public Task<TEntity> Get_Entity_ID(Guid Id);

        public IQueryable<TEntity> Entities { get; }
    }
}
