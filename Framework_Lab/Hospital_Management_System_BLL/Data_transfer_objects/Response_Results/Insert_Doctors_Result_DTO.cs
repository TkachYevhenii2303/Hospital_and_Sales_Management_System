using Labs_EF.Entities;

namespace Hospital_System.Data_transfer_objects.Response_Results
{
    public class Insert_Doctors_Result_DTO
    {
        public string Doctors_name { get; set; } = String.Empty;

        public Specialty Specialty { get; set; }

        public required string Password_hash { get; set; } = string.Empty;

        public required string Email { get; set; } = string.Empty;
    }
}
