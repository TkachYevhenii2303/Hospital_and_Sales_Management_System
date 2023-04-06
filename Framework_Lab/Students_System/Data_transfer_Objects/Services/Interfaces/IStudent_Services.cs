using Students_System.Data_transfer_Objects.Data_Response_Result;
using Students_System.Entities;

namespace Students_System.Data_transfer_Objects.Services.Interfaces
{
    public interface IStudents_Services : IServices<Students, Students_Response_DTO>
    {
        public Task<Students_Response_DTO> Get_Student_ID_Details(Guid ID);
    }
}
