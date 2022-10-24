﻿using AutoMapper;
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



            CreateMap<RoomType, RoomTypeDto>().ReverseMap();


            CreateMap<Room, RoomTypeWithRoomDto>();
            CreateMap<Room, RoomWithCustomerDto>();
            CreateMap<Room, RoomDto>().ReverseMap();
            CreateMap<RoomCreateDto, Room>().ReverseMap();
            CreateMap<RoomUpdateDto, Room>().ReverseMap();



            CreateMap<ExchangeRate, ExchangeRateDto>().ReverseMap();


            CreateMap<PaymentDetail,PaymentDetailDto>().ReverseMap();
            CreateMap<IncomeDetail,IncomeDetailDto>().ReverseMap();
        }
    }
}
