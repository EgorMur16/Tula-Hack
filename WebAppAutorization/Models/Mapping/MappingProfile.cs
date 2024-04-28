using AutoMapper;
using WebAppAutorization.Data;

namespace WebAppAutorization.Models.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Student, StudentModel>()
                .ForMember(dst => dst.DataTravell,
                opt => opt.MapFrom(src => src.DataTravell.Date))
                .ForMember(dst => dst.SerName,
                opt =>opt.MapFrom(src => src.Name + "" + src.Id));
            this.CreateMap<StudentModel, Student>();
        }
    }
}
