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
            CreateMap<TrailView, TrailReadDto>();

            // Mapping for create dto -> to a Trail point model
            CreateMap<TrailCreateDto, TrailView>();

            CreateMap<UserView, UserReadDto>();

            CreateMap<UserCreateDto, UserView>();

            CreateMap<LocationPointsView, LocationPointReadDto>();

            CreateMap<LocationPointCreateDto, LocationPointsView>();
        }
    }
}