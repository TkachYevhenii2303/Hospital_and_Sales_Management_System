using AutoMapper;
using Students_System.Data_transfer_Objects.Data_Response_Result;
using Students_System.Entities;

namespace Students_System.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            this.Mapping_Studetns();
        }

        private void Mapping_Studetns()
        {
            CreateMap<Students, Students_Response_DTO>().ReverseMap();
        }
    }
}
