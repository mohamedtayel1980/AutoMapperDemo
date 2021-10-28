using AutoMapper;
using AutoMapperDemo.Customizations;
using AutoMapperDemo.Models;
using AutoMapperDemo.ViewModels;

namespace AutoMapperDemo.MappingConfigurations
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // Default mapping when property names are same
            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.HasSecondaryAddress, opt => opt.MapFrom(src => !string.IsNullOrEmpty(src.Address.Street2)))
                .ForMember(dest => dest.Bmi, opt => opt.MapFrom<BmiValueResolver>())
                .IncludeMembers(u => u.Address, u => u.AdditionalInfo);
            CreateMap<Address, UserViewModel>(MemberList.None);
            CreateMap<AdditionalInfo, UserViewModel>(MemberList.None);

            // Mapping when property names are different
            //CreateMap<User, UserViewModel>()
            //    .ForMember(dest =>
            //    dest.FName,
            //    opt => opt.MapFrom(src => src.FirstName))
            //    .ForMember(dest =>
            //    dest.LName,
            //    opt => opt.MapFrom(src => src.LastName));
        }
    }

}
