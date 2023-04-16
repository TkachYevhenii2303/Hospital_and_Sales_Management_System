using Mapster;
using Microsoft.Extensions.DependencyInjection;
using Sales_Management_BLL.Data_transfers_Results.Response_Results_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management_BLL.Data_transfers_Results.Configurations.Webframework
{
    public static class MapsterConfigurations
    {
        public static void Insert_Mapster_Configurations(this IServiceCollection services)
        {
            var types_adapter = TypeAdapterConfig.GlobalSettings;
            Assembly assembly = typeof(Base_Response_Result<,>).Assembly;
            types_adapter.Scan(assembly);
        }
    }
}
