using Labs_EF.Entities;

namespace Labs_EF.Data_transfer_Objects.Responses_DTO
{
    public class Get_Doctors_Response_DTO
    {
        public string Doctors_name { get; set; } = String.Empty;

        public Specialty Specialty { get; set; }
    }
}
