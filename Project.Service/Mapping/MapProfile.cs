using AutoMapper;
using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Customer, CustomerListDto>();


            CreateMap<Room, RoomWithCustomerDto>();
            CreateMap<Room, RoomDto>().ReverseMap();
            CreateMap<RoomCreateDto, Room>().ReverseMap();
            CreateMap<RoomUpdateDto, Room>().ReverseMap();



            CreateMap<ExchangeRate, ExchangeRateDto>().ReverseMap();
        }
    }
}
