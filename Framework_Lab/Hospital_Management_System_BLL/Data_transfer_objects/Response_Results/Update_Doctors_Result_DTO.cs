using Labs_EF.Entities;

namespace Hospital_System.Data_transfer_objects.Response_Results
{
    public class Update_Doctors_Result_DTO : Main_Response_Entity
    {
        public string Doctors_name { get; set; } = String.Empty;

        public Specialty Specialty { get; set; }
    }
}
