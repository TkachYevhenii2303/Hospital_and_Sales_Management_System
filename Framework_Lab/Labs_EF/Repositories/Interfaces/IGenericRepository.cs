using Labs_EF.Entities;
using System.Collections;

namespace Labs_EF.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : Entity
    {
        public Task<ServicesResponse<IEnumerable<TEntity>>> Get_all_Information();

        public Task<ServicesResponse<TEntity>?> Get_information_ID(Guid ID);

        public Task<ServicesResponse<IEnumerable<TEntity>>> Insert_Entity(TEntity entity);
    }
}
