﻿using AutoMapper;
using RMS.Core.Entities;
using RMS.Service.DTOs.FoodDTO;
using RMS.Service.DTOs.HallDTO;
using RMS.Service.DTOs.ProductDTO;
using RMS.Service.DTOs.TableDTO;
using RMS.Service.DTOs.TableStatusDTO;
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

            CreateMap<Table, TableGetDTO>().ForMember(x=>x.Status,y=>y.MapFrom(x=>x.Status.Status))
                .ForMember(x=>x.HallName,y=>y.MapFrom(x=>x.Hall.Name));
            CreateMap<Table, TableGetAllDTO>();
            CreateMap<TablePostDTO, Table>();

            CreateMap<Product, ProductGetDTO>();
            CreateMap<Product, ProductGetAllDTO<ProductGetDTO>>();
            CreateMap<Product, ProductGetAllDTO<Product>>();
            CreateMap<ProductPostDTO, Product>();

            CreateMap<TableStatus, TableStatusGetDTO>();
            CreateMap<TableStatus, TableStatusGetAllDTO<TableStatusGetDTO>>();
            CreateMap<TableStatus, TableStatusGetAllDTO<Product>>();
            CreateMap<TableStatusPostDTO, TableStatus>();

            CreateMap<Food, FoodGetDTO>().ForMember(x=>x.Products,y=>y.MapFrom(x=>x.FoodProducts));
            CreateMap<Food, FoodGetAllDTO<FoodGetDTO>>();
            CreateMap<Food, FoodGetAllDTO<Food>>();
            CreateMap<FoodPostDTO, Food>();
            CreateMap<FoodEditDTO, Food>();
        }
    }
}
