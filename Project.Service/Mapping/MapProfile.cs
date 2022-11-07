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



			CreateMap<RoomType, RoomTypeDto>().ReverseMap();


			CreateMap<Room, RoomTypeWithRoomDto>();
			CreateMap<Room, RoomIncomeWithRoomDto>();
			CreateMap<Room, RoomWithCustomerDto>();
			CreateMap<Room, RoomDto>().ReverseMap();
			CreateMap<RoomCreateDto, Room>().ReverseMap();
			CreateMap<RoomUpdateDto, Room>().ReverseMap();

			CreateMap<Room,RoomWithAllRelationalshipDto>();




			CreateMap<ExchangeRate, ExchangeRateDto>().ReverseMap();


			CreateMap<PaymentDetail, PaymentDetailDto>().ReverseMap();
			CreateMap<IncomeDetail, IncomeDetailDto>().ReverseMap();



			CreateMap<IncomeDetail, IncomeWithRoomDto>();
			CreateMap<RoomIncome, RoomIncomeDto>().ReverseMap();
			CreateMap<RoomIncome, RoomIncomeWithRoomDto>().ReverseMap();


			CreateMap<Customer, Record>();
			CreateMap<Record, RecordDto>();

			CreateMap<AppUser, AppUserDto>().ReverseMap();




		}
	}
}
