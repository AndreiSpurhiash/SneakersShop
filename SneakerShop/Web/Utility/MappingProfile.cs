using AutoMapper;
using SneakersShop.ApplicationCore.Entities;
using SneakersShop.Web.Areas.Admin.Models;

namespace SneakersShop.Web.Utility
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Color, ColorViewModel>().ReverseMap();
            CreateMap<Brand, BrandViewModel>().ReverseMap();
            CreateMap<Gender, GenderViewModel>().ReverseMap();
            CreateMap<Color, ColorViewModel>().ReverseMap();
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }  
    }
}
