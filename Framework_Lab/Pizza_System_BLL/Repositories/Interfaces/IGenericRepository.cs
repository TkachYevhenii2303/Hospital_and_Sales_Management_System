using Pizza_System_BLL.Entities;
using System.Collections;

namespace Pizza_System_BLL.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : Entity
    {
        public Task<IEnumerable<TEntity>> Get_all_Information();

        public Task<TEntity?> Get_information_ID(Guid ID);

        public Task<IEnumerable<TEntity>> Insert_Entity(TEntity entity);

        public Task<IEnumerable<TEntity>> Update_Entity(TEntity entity);

        public Task<IEnumerable<TEntity>> Delete_Entity(Guid ID);
    }
}
