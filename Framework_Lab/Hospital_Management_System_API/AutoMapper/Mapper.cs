using AutoMapper;
using Hospital_System.Data_transfer_objects.Response_Results;
using Labs_EF.Entities;

namespace Hospital_System.AutoMapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            this.Generate_map_Doctors();
        }

        private void Generate_map_Doctors()
        {
            CreateMap<Doctors, Get_Doctors_Result_DTO>();
            CreateMap<Insert_Doctors_Result_DTO, Doctors>();
            CreateMap<Update_Doctors_Result_DTO, Doctors>();
        }
    }
}
