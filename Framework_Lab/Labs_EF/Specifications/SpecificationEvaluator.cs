using Labs_EF.Entities;
using Labs_EF.Specifications.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Labs_EF.Specifications
{
    public class SpecificationEvaluator<TEntity> where TEntity : Entity
    {
        public static IQueryable<TEntity> Get_Query(IQueryable<TEntity> base_Query, ISpecifications<TEntity> specifications)
        {
            var result = base_Query;

            if (specifications.Criteria != null)
            {
                result = result.Where(specifications.Criteria);
            }

            if (specifications.OrderBy != null)
            {
                result = result.OrderBy(specifications.OrderBy);
            }

            if (specifications.OrderByDescending != null)
            {
                result = result.OrderByDescending(specifications.OrderByDescending);
            }

            result = specifications.Includes.Aggregate(result,
                (current, include) => current.Include(include));

            return result;
        }
    }
}
