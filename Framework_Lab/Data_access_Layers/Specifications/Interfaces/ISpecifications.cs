﻿using Labs_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data_access_Layers.Specifications.Interfaces
{
    public interface ISpecifications<TEntity>
        where TEntity : Entity
    {
        public Expression<Func<TEntity, bool>>? Criteria { get; }

        public List<Expression<Func<TEntity, object>>> Include_Expression { get; }

        public Expression<Func<TEntity, object>>? Order_by_Expression { get; }

        public Expression<Func<TEntity, object>>? Order_by_Descending_Expression { get; }
    }
}
