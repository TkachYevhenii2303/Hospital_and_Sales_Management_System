using System.Linq.Expressions;

namespace Students_System.Data_transfer_Objects.Services.Interfaces
{
    public interface IServices<TEntity, TData_transfer_object>
    {
        public IEnumerable<TData_transfer_object> Get_all_Information(Expression<Func<TData_transfer_object, bool>>? expression = null);

        public Task<TData_transfer_object> Get_Entity_ID(Guid Id);
    }
}
