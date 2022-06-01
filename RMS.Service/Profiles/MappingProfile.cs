using AutoMapper;
using RMS.Core.Entities;
using RMS.Service.DTOs.CategoryDTO;
using RMS.Service.DTOs.FoodDTO;
using RMS.Service.DTOs.HallDTO;
using RMS.Service.DTOs.OrderDTO;
using RMS.Service.DTOs.OrderTypeDTO;

using RMS.Service.DTOs.ProductDTO;
using RMS.Service.DTOs.ProductTypeDTO;
using RMS.Service.DTOs.ReceiptDTO;
using RMS.Service.DTOs.StaffDTO;
using RMS.Service.DTOs.ReservationDTO;
using RMS.Service.DTOs.StaffTypeDTO;
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
            CreateMap<TableUpdateDTO, Table>().ReverseMap();

            CreateMap<Product, ProductGetDTO>();
            CreateMap<Product, ProductGetAllDTO<ProductGetDTO>>();
            CreateMap<Product, ProductGetAllDTO<Product>>();
            CreateMap<ProductPostDTO, Product>();


            CreateMap<TableStatus, TableStatusGetDTO>();
            CreateMap<TableStatus, TableStatusGetAllDTO<TableStatusGetDTO>>();
            CreateMap<TableStatus, TableStatusGetAllDTO<Product>>();
            CreateMap<TableStatusPostDTO, TableStatus>();

            CreateMap<Food, FoodGetDTO>()
                .ForMember(x => x.Category, y => y.MapFrom(x => x.Category.Name))
                .ForMember(x => x.File, y => y.MapFrom(x => x.Image));
            CreateMap<Food, FoodGetAllDTO<FoodGetDTO>>();
            CreateMap<Food, FoodGetAllDTO<Food>>();
            CreateMap<FoodPostDTO, Food>();
            CreateMap<FoodEditDTO, Food>().ReverseMap();

            CreateMap<Category, CategoryGetDTO>().ForMember(x => x.Foods, y => y.MapFrom(x => x.Foods));
            CreateMap<Category, CategoryGetAllDTO<CategoryGetDTO>>();
            CreateMap<Category, CategoryGetAllDTO<Category>>();
            CreateMap<CategoryPostDTO, Category>();
            CreateMap<CategoryEditDTO, Category>().ReverseMap();

            CreateMap<ProductType, ProductTypeGetDTO>();
            CreateMap<ProductType, ProductTypeGetAllDTO<ProductTypeGetDTO>>();
            CreateMap<ProductType, ProductTypeGetAllDTO<ProductType>>();
            CreateMap<ProductTypePostDTO, ProductType>();


            CreateMap<Order, OrderGetDTO>()
                .ForMember(x => x.Foods, y => y.MapFrom(x => x.FoodOrders))
                .ForMember(x => x.TableNumber, y => y.MapFrom(x => x.Table.Number))
                .ForMember(x => x.StaffName, y => y.MapFrom(x => x.Staff.FullName));
            CreateMap<Order, OrderGetAllDTO>();
            CreateMap<OrderPostDTO, Order>();
            CreateMap<FoodOrder, OrderFoodGetDTO>()
                .ForMember(x => x.Name, y => y.MapFrom(x => x.Food.Name))
                .ForMember(x => x.Price, y => y.MapFrom(x => x.Food.Price))
                .ForMember(x => x.Count, y => y.MapFrom(x => x.FoodAmount));


            CreateMap<StaffType, StaffTypeGetDTO>();
            CreateMap<StaffType, StaffTypeGetAllDTO<StaffTypeGetDTO>>();
            CreateMap<StaffTypePostDTO, StaffType>();

            CreateMap<Receipt, ReceiptGetDTO>();
            CreateMap<Receipt, ReceiptGetAllDTO<ReceiptGetDTO>>();
            CreateMap<ReceiptPostDTO, Receipt>();

            CreateMap<Staff, StaffGetDTO>().ForMember(x => x.StaffType, y => y.MapFrom(x => x.StaffType.Name));
            CreateMap<Staff, StaffCreateReturnDTO>().ForMember(x => x.StaffType, y => y.MapFrom(x => x.StaffType.Name));
            CreateMap<Staff, StaffGetAllDTO<StaffGetDTO>>();
            CreateMap<StaffPostDTO, Staff>();

            CreateMap<Reservation, ReservationGetDTO>();
            CreateMap<Reservation, ReservationGetAllDTO<ReservationGetDTO>>();
            CreateMap<ReservationPostDTO, Reservation>().ForMember(x => x.Time, y => y.MapFrom(x => x.Time.AddHours(4)));

        }
    }
}
