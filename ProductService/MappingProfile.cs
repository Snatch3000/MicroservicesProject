using AutoMapper;
using ProductService.Client.Models;
using ProductService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductCreateModel>().ReverseMap();
            CreateMap<Product, ProductGetModel>().ReverseMap();
        }
    }
}
