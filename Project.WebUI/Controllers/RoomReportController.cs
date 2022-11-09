using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;
using Project.WebUI.ViewModel;

namespace Project.WebUI.Controllers
{
	public class RoomReportController : Controller
	{
		private readonly IRoomService _roomService;
		private readonly IIncomeDetailService _incomeDetailService;
		private readonly IRoomIncomeService _roomIncomeService;
		private readonly IPaymentDetailService _paymentDetailService;
		private readonly IMapper _mapper;

		public RoomReportController(IRoomService roomService, IMapper mapper, IIncomeDetailService incomeDetailService, IPaymentDetailService paymentDetailService, IRoomIncomeService roomIncomeService)
		{
			_roomService = roomService;
			_mapper = mapper;
			_incomeDetailService = incomeDetailService;
			_paymentDetailService = paymentDetailService;
			_roomIncomeService = roomIncomeService;
		}

		public async Task<IActionResult> Index()
		{
			List<Room> rooms =  _roomService.GetAll().ToList();
			List<RoomDto> roomsDto = _mapper.Map<List<RoomDto>>(rooms);
            ViewBag.rooms = new SelectList(roomsDto, "Id", "RoomName");

            return View();
		}

		public async Task<IActionResult> GetBySelected(DateTime selectedDate, int roomId)
		{

			List<IncomeWithRoomDto> incomeWithRoomDtos = await _incomeDetailService.GetIncomeWithSingleRoomIdAsync(roomId,selectedDate);
            List<PaymentDetailWithRoomDto> paymentWithRoomDtos = await _paymentDetailService.GetPaymentWithSingleRoomIdAsync(roomId, selectedDate);
			List<RoomIncomeWithRoomDto> roomIncomeWithRoomDtos = await _roomIncomeService.GetRoomIncomeWithSingleRoomIdAsync(roomId, selectedDate);

			SingleRoomReports_VM singleRoomReports_VM = new SingleRoomReports_VM
			{
				IncomeWithRoomDtos = incomeWithRoomDtos,
				PaymentDetailWithRoomDtos = paymentWithRoomDtos,
				RoomIncomeWithRoomDtos = roomIncomeWithRoomDtos,
            };

            return View(singleRoomReports_VM);
		}
	}
}
