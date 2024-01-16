using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ohjelmistokehitysprojekti_2_backend.Models.Domain;
using ohjelmistokehitysprojekti_2_backend.Models.DTO.Users;

namespace ohjelmistokehitysprojekti_2_backend.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
            CreateMap<User, UserRegisterDto>().ReverseMap();
        }
    }
}