using Labs_EF.Entities;

namespace Hospital_System_Blazor.Services.Interfaces
{
    public interface IEmployeeServices
    {
        public Task<IEnumerable<Doctors>?> Get_all_Employees();
    }
}
