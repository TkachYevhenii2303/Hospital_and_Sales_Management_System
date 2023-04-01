using Labs_EF.Entities;
using Labs_EF.Specifications.Interfaces;
using System.Linq.Expressions;

namespace Labs_EF.Specifications
{
    public class Specifications<TEntity> : ISpecifications<TEntity> where TEntity : Entity
    {
        public Specifications()
        {
        }

        public Specifications(Expression<Func<TEntity, bool>> Criteria)
        {
            this.Criteria = Criteria;
        }

        public Expression<Func<TEntity, bool>> Criteria { get; }

        public List<Expression<Func<TEntity, object>>> Includes { get; } = new List<Expression<Func<TEntity, object>>>();

        public Expression<Func<TEntity, object>> OrderBy { get; private set; }

        public Expression<Func<TEntity, object>> OrderByDescending { get; private set; }

        protected void Create_Includes(Expression<Func<TEntity, object>> includes) => Includes.Add(includes);

        protected void Create_OrderBy(Expression<Func<TEntity, object>> orderBy) => OrderBy = orderBy;
        
        protected void Create_OrderByDescending(Expression<Func<TEntity, object>> orderByDescending) => OrderByDescending = orderByDescending;  
    }
}
