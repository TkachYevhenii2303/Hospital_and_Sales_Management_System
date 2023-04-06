using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Students_System.Data_transfer_Objects.Data_Response_Result;
using Students_System.Data_transfer_Objects.Services.Interfaces;
using Students_System.Entities;
using Students_System.Repository.Interfaces;

namespace Students_System.Data_transfer_Objects.Services
{
    public class Student_Services : Services<Students, Students_Response_DTO>//, IStudents_Services
    {
        private readonly IMapper _mapper;
        private IGenericRepository<Students> _students_Repository;

        public Student_Services(IMapper mapper, IGenericRepository<Students> repository) : base(mapper, repository)
        {
            this._mapper = mapper;
            this._students_Repository = repository;
        }

       /* public async Task<Students_Response_DTO> Get_Student_ID_Details(Guid ID)
        {
            var students = await _students_Repository.Entities.Include(a => 
            a.)
            return _mapper.Map<Students_Response_DTO>()
        }*/
    }
}
