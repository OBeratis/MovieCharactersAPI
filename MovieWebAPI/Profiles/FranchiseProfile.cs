using System.Linq;
using AutoMapper;
using MovieWebAPI.Models;
using MovieWebAPI.DTO;

namespace MovieWebAPI.Profiles
{
    public class FranchiseProfile : Profile
    {
        public FranchiseProfile()
        {
            CreateMap<Franchise, FranchiseEditDTO>()
                .ForMember(cdto => cdto.Movies, opt => opt
                .MapFrom(f => f.Movies.Select(m => m.Id).ToArray()))
                .ReverseMap();
        }
    }
}
