using AutoMapper;
using MovieApi.Models;
using MovieApi.Models.DTOs;

namespace MovieApi.Data
{
    public class MapperProfile: Profile
    {
        public MapperProfile() 
        {
        CreateMap<Movie, MovieDto>()
            .ForMember(dest => dest.MovieDetails, opt => opt.MapFrom(src => src.MovieDetails))
            .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews))
            .ForMember(dest => dest.Actor, opt => opt.MapFrom(src => src.Actor));

        CreateMap<Actor,ActorDto>();
        CreateMap<MovieDetails, MovieDetailsDto>();
        CreateMap<Review, ReviewDto>();
        }
    }
}
