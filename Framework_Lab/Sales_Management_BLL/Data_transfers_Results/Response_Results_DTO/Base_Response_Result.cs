using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_BLL.Data_transfers_Results.Response_Results_DTO
{
    public abstract class Base_Response_Result<TData_transfer, TEntity> : IRegister
        where TData_transfer : class, new()
        where TEntity : class, new()    
    {
        public Guid ID { get; set; }

        private TypeAdapterConfig? Configurations { get; set; } 

        protected virtual void Insert_Mapping() { }

        public void Register(TypeAdapterConfig configurations)
        {
            this.Configurations = configurations;
            this.Insert_Mapping();
        }

        public TEntity Entity_to() => this.Adapt<TEntity>();

        public TEntity Entity_to(TEntity entity) => (this as TData_transfer).Adapt(entity);

        public static TData_transfer Entity_from(TEntity entity) => entity.Adapt<TData_transfer>();

        protected TypeAdapterSetter<TData_transfer, TEntity> Set_Custom_Mapping()
            => Configurations.ForType<TData_transfer, TEntity>();

        protected TypeAdapterSetter<TEntity, TData_transfer> Set_Custom_Mapping_Inverse()
            => Configurations.ForType<TEntity, TData_transfer>();
    }
}
