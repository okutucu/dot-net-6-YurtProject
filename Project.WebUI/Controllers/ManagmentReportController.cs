using Microsoft.AspNetCore.Mvc;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;
using Project.WebUI.ViewModel;

namespace Project.WebUI.Controllers
{
	public class ManagmentReportController : Controller
	{
        private readonly IRoomService _roomService;
        private readonly IIncomeDetailService _incomeDetailService;
        private readonly IRoomIncomeService _roomIncomeService;
        private readonly IPaymentDetailService _paymentDetailService;

        public ManagmentReportController(IRoomService roomService, IIncomeDetailService incomeDetailService, IRoomIncomeService roomIncomeService, IPaymentDetailService paymentDetailService)
		{
			_roomService = roomService;
			_incomeDetailService = incomeDetailService;
			_roomIncomeService = roomIncomeService;
			_paymentDetailService = paymentDetailService;
		}


        public IActionResult Index()
		{
			return View();
		}

        public async Task<IActionResult> GetBySelected(string selectedDate)
        {
            ViewBag.date = selectedDate;
            List<IncomeWithRoomDto> incomeWithRoomDtos = await _incomeDetailService.DailyOrMonthly(selectedDate);
            List<PaymentDetailWithRoomDto> paymentWithRoomDtos = await  _paymentDetailService.DailyOrMonthly(selectedDate);
            List<RoomIncomeWithRoomDto> roomIncomeWithRoomDtos = await _roomIncomeService.DailyOrMonthly(selectedDate);

            SingleRoomReports_VM singleRoomReports_VM = new SingleRoomReports_VM
            {
                IncomeWithRoomDtos = incomeWithRoomDtos,
                PaymentDetailWithRoomDtos = paymentWithRoomDtos,
                RoomIncomeWithRoomDtos = roomIncomeWithRoomDtos,
            };

            return View(singleRoomReports_VM);
        }

        public async Task<JsonResult> VisualizeRoomRentResult(string selectedDate)
        {
            List<IncomeWithRoomDto> incomeWithRoomDtos = await _incomeDetailService.DailyOrMonthly(selectedDate);
            var datas = (from exchange in incomeWithRoomDtos
                         group exchange by exchange.Price
                                 into exchangeGroup
                         select new
                         {
                             Exchange = exchangeGroup.Key,
                             Sum = exchangeGroup.Sum(s => s.Price)
                         }).ToList();



            return Json(datas);
        }


    }
}
