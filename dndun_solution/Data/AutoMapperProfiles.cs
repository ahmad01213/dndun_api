using System;
using AutoMapper;
using dndun_solution.Data.ViewModels;
using dndun_solution.Models;

namespace dndun_solution.Data
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserForRegister, User>();
            CreateMap<User, UserDetailResponse>();
        }
    }
}

