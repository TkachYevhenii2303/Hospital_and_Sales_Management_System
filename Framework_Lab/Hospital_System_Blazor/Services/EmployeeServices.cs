using Hospital_System_Blazor.Services.Interfaces;
using Labs_EF.Entities;
using System.Net.Http.Json;

namespace Hospital_System_Blazor.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly HttpClient _http_Client;

        public EmployeeServices(HttpClient http_Client)
        {
            _http_Client = http_Client;
        }

        public async Task<IEnumerable<Doctors>?> Get_all_Employees()
        {
            return await _http_Client.GetFromJsonAsync<IEnumerable<Doctors>>("api/doctors/Get_all_Employees");
        }
    }
}
