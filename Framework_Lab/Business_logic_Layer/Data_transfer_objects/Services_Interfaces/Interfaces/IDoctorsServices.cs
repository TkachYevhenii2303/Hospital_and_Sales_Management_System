using Hospital_System.Data_transfer_objects.Response_Results;

namespace Hospital_System.Data_transfer_objects.Services_Interfaces.Interfaces
{
    public interface IDoctorsServices
    {
        public Task<IEnumerable<Get_Doctors_Result_DTO>> Get_all_Doctors();

        public Task<Get_Doctors_Result_DTO> Get_Doctor_ID(Guid ID);

        public Task<IEnumerable<Get_Doctors_Result_DTO>> Insert_Doctors(Insert_Doctors_Result_DTO doctors);

        public Task<IEnumerable<Get_Doctors_Result_DTO>> Update_Doctrors(Update_Doctors_Result_DTO doctors);

        public Task<IEnumerable<Get_Doctors_Result_DTO>> Delete_Doctrors(Guid ID);
    }
}
