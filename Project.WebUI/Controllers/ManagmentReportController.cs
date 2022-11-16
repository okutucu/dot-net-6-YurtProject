using System.Security.Cryptography;
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

        [HttpGet]
        public async Task<JsonResult> VisualizeRoomRentResult(string selectedDate)
        {
            List<RoomIncomeWithRoomDto> roomIncomeWithRoomDtos = await _roomIncomeService.DailyOrMonthly(selectedDate);
            var allRentIncomesWithExchange = (from exchange in roomIncomeWithRoomDtos
                         group exchange by exchange.Exchange.ToString()
                                 into exchangeGroup
                         select new
                         {
                             Exchange = exchangeGroup.Key,
                             Sum = exchangeGroup.Sum(s => s.Price)
                         }).ToList();
            var allRentIncomesWithPaymentMethod = from payment in roomIncomeWithRoomDtos
                                                  group payment by payment.PaymentMethod.ToString() into payments
                                                  select new
                                                  {
                                                      PaymentMethod = payments.Key,
                                                      PaymentDetail = from paymentDetail in payments
                                                                      group paymentDetail by paymentDetail.Exchange.ToString() into paymentDetailGroup
                                                                      select new
                                                                      {
                                                                          Exchange = paymentDetailGroup.Key,
                                                                          Sum = paymentDetailGroup.Sum(x => x.Price),
                                                                      }
                                                  };
           



            var allRentIncomes = new
            {
                allRentIncomesWithPaymentMethod,
                allRentIncomesWithExchange
            };

            return Json(allRentIncomes);
        }

        [HttpGet]
        public async Task<JsonResult> VisualizeOtherIncomesResult(string selectedDate)
        {
            List<IncomeWithRoomDto> incomeWithRoomDtos = await _incomeDetailService.DailyOrMonthly(selectedDate);
            var allIncomesDetailWithExchange = (from exchange in incomeWithRoomDtos
                                              group exchange by exchange.Exchange.ToString()
                                 into exchangeGroup
                                              select new
                                              {
                                                  Exchange = exchangeGroup.Key,
                                                  Sum = exchangeGroup.Sum(s => s.Price)
                                              }).ToList();
            var allIncomesDetailWithPaymentMethod = from payment in incomeWithRoomDtos
                                                  group payment by payment.PaymentMethod.ToString() into payments
                                                  select new
                                                  {
                                                      PaymentMethod = payments.Key,
                                                      PaymentDetail = from paymentDetail in payments
                                                                      group paymentDetail by paymentDetail.Exchange.ToString() into paymentDetailGroup
                                                                      select new
                                                                      {
                                                                          Exchange = paymentDetailGroup.Key,
                                                                          Sum = paymentDetailGroup.Sum(x => x.Price),
                                                                      }
                                                  };

            var allIncomesDetail = new
            {
                allIncomesDetailWithExchange,
                allIncomesDetailWithPaymentMethod
            };

            return Json(allIncomesDetail);
        }

        [HttpGet]
        public async Task<JsonResult> VisualizePaymentResult(string selectedDate)
        {
            List<PaymentDetailWithRoomDto> paymentWithRoomDtos = await _paymentDetailService.DailyOrMonthly(selectedDate);
            var allPaymentDetailWithExchange = (from exchange in paymentWithRoomDtos
                                                group exchange by exchange.Exchange.ToString()
                                 into exchangeGroup
                                                select new
                                                {
                                                    Exchange = exchangeGroup.Key,
                                                    Sum = exchangeGroup.Sum(s => s.Price)
                                                }).ToList();
            var allpaymentDetailWithPaymentMethod = from payment in paymentWithRoomDtos
                                                    group payment by payment.PaymentMethod.ToString() into payments
                                                    select new
                                                    {
                                                        PaymentMethod = payments.Key,
                                                        PaymentDetail = from paymentDetail in payments
                                                                        group paymentDetail by paymentDetail.Exchange.ToString() into paymentDetailGroup
                                                                        select new
                                                                        {
                                                                            Exchange = paymentDetailGroup.Key,
                                                                            Sum = paymentDetailGroup.Sum(x => x.Price),
                                                                        }
                                                    };

            var allPaymentDetail = new
            {
                allPaymentDetailWithExchange,
                allpaymentDetailWithPaymentMethod
            };

            return Json(allPaymentDetail);
        }



    }
}
