using AutoMapper;
using RMS.Core.Entities;
using RMS.Service.DTOs.HallDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hall, HallGetDTO>();
            CreateMap<Hall, HallGetAllDTO>();
            CreateMap<HallPostDTO, Hall>();
        }
    }
}
