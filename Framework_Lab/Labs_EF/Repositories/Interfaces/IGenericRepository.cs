﻿using Labs_EF.Entities;
using Labs_EF.Specifications.Interfaces;

namespace Labs_EF.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : Entity
    {
        public Task<IEnumerable<ServicesResponse<TEntity>>> Get_all_Information();

        public Task<ServicesResponse<TEntity>?> Get_information_ID(Guid ID);

        public IEnumerable<TEntity> Find_with_Specification_Pattern(ISpecifications<TEntity> specifications = null);
    }
}
