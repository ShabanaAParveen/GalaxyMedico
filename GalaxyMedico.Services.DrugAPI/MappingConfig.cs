using AutoMapper;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GalaxyMedico.Services.DrugAPI.Models.Dto;
using GalaxyMedico.Services.DrugAPI.Models;

namespace GalaxyMedico.Services.DrugAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps(){        
            var mappingConfig=new MapperConfiguration(config=>{
                config.CreateMap<DrugDto, Drug>();
                config.CreateMap<Drug, DrugDto>();
            });
            return mappingConfig;
        }
    }
}
