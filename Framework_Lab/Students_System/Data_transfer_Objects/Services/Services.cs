using AutoMapper;
using Students_System.Data_transfer_Objects.Data_Response_Result;
using Students_System.Data_transfer_Objects.Services.Interfaces;
using Students_System.Entities;
using Students_System.Repository.Interfaces;
using System.Linq.Expressions;

namespace Students_System.Data_transfer_Objects.Services
{
    public class Services<TEntity, TData_transfer_object> : IServices<TEntity, TData_transfer_object>
        where TEntity : Entity where TData_transfer_object : Entity_Data_transfer
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<TEntity> _repository;

        public Services(IMapper mapper, IGenericRepository<TEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<TData_transfer_object> Get_all_Information(Expression<Func<TData_transfer_object, bool>>? expression = null)
        {
            var predicate = _mapper.Map<Expression<Func<TEntity, bool>>>(expression);
            return _repository.Get_all_Information(predicate).Select(_mapper.Map<TData_transfer_object>).ToList();
        }

        public async Task<TData_transfer_object> Get_Entity_ID(Guid Id)
        {
            var entity = await _repository.Get_Entity_ID(Id);
            return _mapper.Map<TData_transfer_object>(entity);
        }
    }
}
