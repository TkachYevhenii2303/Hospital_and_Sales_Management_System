using Data_access_Layers.Specifications.Interfaces;
using Labs_EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_access_Layers.Specifications
{
    public class Specifications_Evaluator<TEntity>
        where TEntity : Entity
    {
        public static IQueryable<TEntity> Get_all_Information(IQueryable<TEntity> query_Information, ISpecifications<TEntity> specifications)
        {
            var result = query_Information;

            if (specifications.Criteria != null)
            {
                result = result.Where(specifications.Criteria);
            }

            if (specifications.Order_by_Expression != null)
            {
                result = result.OrderBy(specifications.Order_by_Expression);
            }

            if (specifications.Order_by_Descending_Expression != null)
            {
                result = result.OrderByDescending(specifications.Order_by_Descending_Expression);
            }

            // Includes all expression-based includes
            result = specifications.Include_Expression.Aggregate(result, (current, include) => current.Include(include));

            return result;
        }
    }
}
