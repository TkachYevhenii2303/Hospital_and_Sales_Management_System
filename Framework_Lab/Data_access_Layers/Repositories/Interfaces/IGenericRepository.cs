using Data_access_Layers.Specifications;
using Data_access_Layers.Specifications.Interfaces;
using Labs_EF.Entities;
using System.Collections;

namespace Labs_EF.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : Entity
    {
        public Task<IEnumerable<TEntity>> Get_all_Information();

        public Task<TEntity?> Get_information_ID(Guid ID);

        public Task<IEnumerable<TEntity>> Insert_Entity(TEntity entity);

        public Task<IEnumerable<TEntity>> Update_Entity(TEntity entity);

        public Task<IEnumerable<TEntity>> Delete_Entity(Guid ID);

        public IEnumerable<TEntity> Find_with_Specifications_Pattern(ISpecifications<TEntity> specifications);
    }
}
