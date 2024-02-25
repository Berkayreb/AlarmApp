using AlarmApp.Entity.Model;
using AlarmApp.Web.Dtos;
using AutoMapper;

namespace AlarmApp.Web.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {


            CreateMap<Alarm, AlarmDto>();
    


        }
    }
}
