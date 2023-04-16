using Microsoft.EntityFrameworkCore;
using Sales_Management_DAL.Entities;
using Sales_Management_DAL.Specifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_DAL.Specifications
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

            result = specifications.Include_Expression.Aggregate(result, (current, include) => current.Include(include));

            return result;
        }
    }
}
