using AutoMapper;
using RMS.Core.Entities;
using RMS.Service.DTOs.HallDTO;
using RMS.Service.DTOs.ProductDTO;
using RMS.Service.DTOs.TableDTO;
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

            CreateMap<Table, TableGetDTO>();
            CreateMap<Table, TableGetAllDTO>();
            CreateMap<TablePostDTO, Table>();

            CreateMap<Product, ProductGetDTO>();
            CreateMap<Product, ProductGetAllDTO<ProductGetDTO>>();
            CreateMap<Product, ProductGetAllDTO<Product>>();
            CreateMap<ProductPostDTO, Product>();
        }
    }
}
