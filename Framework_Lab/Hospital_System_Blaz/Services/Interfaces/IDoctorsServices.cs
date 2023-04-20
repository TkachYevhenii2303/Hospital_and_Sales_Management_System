using Labs_EF.Entities;

namespace Hospital_System_Blaz.Services.Interfaces
{
    public interface IDoctorsServices
    {
        public Task<IEnumerable<Doctors>> Get_all_Doctors();
    }
}
