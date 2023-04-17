using AutoMapper;
using GalaxyMedico.Services.ShoppingCartAPI.Models;
using GalaxyMedico.Services.ShoppingCartAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedico.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfigs = new MapperConfiguration(
              config =>
              {
                  config.CreateMap<DrugDto, Drug>().ReverseMap();
                  config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
                  config.CreateMap<CartHeaderDto, CartHeader>().ReverseMap();
                  config.CreateMap<CartDto, Cart>().ReverseMap();
              });

            return mappingConfigs;
        }
    }
}
