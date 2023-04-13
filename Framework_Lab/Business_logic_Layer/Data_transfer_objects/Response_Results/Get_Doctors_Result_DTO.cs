using Labs_EF.Entities;
using System.ComponentModel.DataAnnotations;

namespace Hospital_System.Data_transfer_objects.Response_Results
{
    public class Get_Doctors_Result_DTO : Main_Response_Entity
    {
        public string Doctors_name { get; set; } = String.Empty;

        public Specialty Specialty { get; set; }
    }
}
