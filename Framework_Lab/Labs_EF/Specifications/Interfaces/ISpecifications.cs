using Labs_EF.Entities;
using System.Linq.Expressions;

namespace Labs_EF.Specifications.Interfaces
{
    public interface ISpecifications<TEntity> where TEntity : Entity
    {
        public Expression<Func<TEntity, bool>> Criteria { get; }

        public List<Expression<Func<TEntity, object>>> Includes { get; }

        public Expression<Func<TEntity, object>> OrderBy { get; }

        public Expression<Func<TEntity, object>> OrderByDescending { get; }
    }
}
