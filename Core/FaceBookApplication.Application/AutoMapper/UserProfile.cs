using AutoMapper;
using FaceBookApplication.Application.ViewModel;
using FaceBookApplication.Domain.Entity;

namespace FaceBookApplication.Application.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserVM>().ReverseMap();
        }
    }
}
