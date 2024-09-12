using AutoMapper;
using KWA_Djole.Business.Dtos;
using KWA_Djole.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWA_Djole.Business.Infrastructure.Automapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<BaseModel, BaseDto>().ReverseMap();
        }
    }
}