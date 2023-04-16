using Data_access_Layers.Specifications.Interfaces;
using Labs_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data_access_Layers.Specifications
{
    public abstract class Specifications<TEntity> : ISpecifications<TEntity>
        where TEntity : Entity
    {
        protected Specifications() { }

        protected Specifications(Expression<Func<TEntity, bool>>? criteria) =>
            Criteria = criteria;

        public Expression<Func<TEntity, bool>>? Criteria { get; }

        public List<Expression<Func<TEntity, object>>> Include_Expression { get; } = new();
        
        public Expression<Func<TEntity, object>>? Order_by_Expression { get; private set; }

        public Expression<Func<TEntity, object>>? Order_by_Descending_Expression { get; private set; }

        protected void Insert_Include(Expression<Func<TEntity, object>> include_Expression) =>
            Include_Expression.Add(include_Expression);

        protected void Insert_Order_By(Expression<Func<TEntity, object>> order_by_Expression) =>
            Order_by_Expression = order_by_Expression;

        protected void Insert_Order_By_Descending(Expression<Func<TEntity, object>> order_by_Decsending_Expression) =>
            Order_by_Descending_Expression = order_by_Decsending_Expression;
    }
}
