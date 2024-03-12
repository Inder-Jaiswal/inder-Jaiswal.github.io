using AutoMapper;
using Port.Data.Entities;
using Port.Models;

namespace Port.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile() {

            CreateMap<Home, DescriptionModel>().ReverseMap();
        }
    }
}
