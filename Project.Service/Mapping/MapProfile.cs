using AutoMapper;
using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Customer , CustomerListDto>().ReverseMap();
        }
    }
}
