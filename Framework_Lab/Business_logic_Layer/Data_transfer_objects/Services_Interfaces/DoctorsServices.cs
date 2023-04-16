using AutoMapper;
using Data_access_Layers.Specifications.Services;
using Hospital_System.Data_transfer_objects.Response_Results;
using Hospital_System.Data_transfer_objects.Services_Interfaces.Interfaces;
using Labs_EF.Entities;
using Labs_EF.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Hospital_System.Data_transfer_objects.Services_Interfaces
{
    public class DoctorsServices : IDoctorsServices
    {
        private readonly IUnit_of_Work _unit_Of_Work;
        private readonly IMapper _mapper;

        public DoctorsServices(IUnit_of_Work unit_Of_Work, IMapper mapper)
        {
            _unit_Of_Work = unit_Of_Work;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Get_Doctors_Result_DTO>> Delete_Doctrors(Guid ID)
        {
            var result = await _unit_Of_Work.Doctros_Repository.Delete_Entity(ID);

            _unit_Of_Work.Complete();

            return _mapper.Map<IEnumerable<Doctors>, IEnumerable<Get_Doctors_Result_DTO>>(result);
        }

        public async Task<IEnumerable<Get_Doctors_Result_DTO>> Get_all_Doctors()
        {
            var result = await _unit_Of_Work.Doctros_Repository.Get_all_Information();

            return _mapper.Map<IEnumerable<Doctors>, IEnumerable<Get_Doctors_Result_DTO>>(result);
        }

        public async Task<Get_Doctors_Result_DTO> Get_Doctor_ID(Guid ID)
        {
            var result = await _unit_Of_Work.Doctros_Repository.Get_information_ID(ID);

            return _mapper.Map<Get_Doctors_Result_DTO>(result);
        }

        public async Task<IEnumerable<Get_Doctors_Result_DTO>> Insert_Doctors(Insert_Doctors_Result_DTO doctors)
        {
            var result = await _unit_Of_Work.Doctros_Repository.Insert_Entity(_mapper.Map<Doctors>(doctors));

            _unit_Of_Work.Complete();

            return _mapper.Map<IEnumerable<Doctors>, IEnumerable<Get_Doctors_Result_DTO>>(result);
        }

        public async Task<IEnumerable<Get_Doctors_Result_DTO>> Update_Doctrors(Update_Doctors_Result_DTO doctors)
        {
            var result = await _unit_Of_Work.Doctros_Repository.Update_Entity(_mapper.Map<Doctors>(doctors));

            _unit_Of_Work.Complete();

            return _mapper.Map<IEnumerable<Doctors>, IEnumerable<Get_Doctors_Result_DTO>>(result);
        }

        public IEnumerable<Get_Doctors_Result_DTO> Find_Doctors_Speciality(string speciality)
        {
            var result = _unit_Of_Work.Doctros_Repository.Find_with_Specifications_Pattern(new DoctorsSpecializations(speciality));

            return _mapper.Map<IEnumerable<Doctors>, IEnumerable<Get_Doctors_Result_DTO>>(result);
        }

        public async Task<IEnumerable<string>> Get_all_Specialities()
        {
            return await _unit_Of_Work.Doctros_Repository.Get_all_Specialities();
        }
    }
}
