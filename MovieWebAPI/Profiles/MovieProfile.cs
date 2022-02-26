using System.Linq;
using AutoMapper;
using MovieWebAPI.Models;
using MovieWebAPI.DTO;

namespace MovieWebAPI.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieEditDTO>()
                .ForMember(cdto => cdto.Characters, opt => opt
                .MapFrom(m => m.Characters.Select(c => c.Id).ToArray()))
                .ReverseMap();
        }
    }
}
