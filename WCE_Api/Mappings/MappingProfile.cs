using AutoMapper;
using WCE_Api.Entities;
using WCE_Api.ViewModels;

namespace WCE_Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterUserViewModel, AppUser>();
        }
    }
}