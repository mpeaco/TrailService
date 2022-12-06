using AutoMapper;
using TrailService.Dtos;
using TrailService.Models;

namespace TrailService.Profiles
{
    public class TrailsProfile : Profile
    {
        public TrailsProfile()
        {
            // Create mappings from source to target: Trail Model -> TrailReadDto
            CreateMap<TrailPoint, TrailReadDto>();

            // Mapping for create dto -> to a Trail point model
            CreateMap<TrailCreateDto, TrailPoint>();
        }
    }
}