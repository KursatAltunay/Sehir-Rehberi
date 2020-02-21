using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SehirRehberi.API.DTOs;
using SehirRehberi.API.Models;

namespace SehirRehberi.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<City, CityForListDTO>()
                .ForMember(dest => dest.PhotoUrl, opt =>
                   {
                       opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                   });

            CreateMap<City, CityForDetailDTO>();
            CreateMap<PhotoForCreationDTO,Photo>();
            CreateMap<PhotoForReturnDTO, Photo>();

        }
    }
}
