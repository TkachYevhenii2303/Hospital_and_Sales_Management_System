using Hospital_System_Blaz.Services.Interfaces;
using Labs_EF.Entities;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace Hospital_System_Blaz.Services
{
    public class DoctorsServices : IDoctorsServices
    {
        private readonly HttpClient _http_client;

        public DoctorsServices(HttpClient http_client)
        {
            _http_client = http_client;
        }

        public Task<IEnumerable<Doctors>> Get_all_Doctors()
        {
            throw new NotImplementedException();
        }
    }
}
