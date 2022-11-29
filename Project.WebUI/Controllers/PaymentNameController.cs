using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Services;

namespace Project.WebUI.Controllers
{
    [Authorize(Policy = "AdminPolicy")]
    public class PaymentNameController : Controller
    {
        private readonly IService<PaymentName> _service;
        private readonly IMapper _mapper;

        public PaymentNameController(IService<PaymentName> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            List<PaymentName> paymentName = _service.GetAll().ToList();

            return View(_mapper.Map<List<PaymentNameDto>>(paymentName));
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(PaymentNameDto paymentNameDto)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(_mapper.Map<PaymentName>(paymentNameDto));
                return RedirectToAction(nameof(Index));
            }
            return View(paymentNameDto);

        }

        [ServiceFilter(typeof(NotFoundFilter<PaymentName>))]
        public async Task<IActionResult> Update(int id)
        {
            PaymentName paymentName = await _service.GetByIdAsync(id);
            return View(_mapper.Map<PaymentNameDto>(paymentName));
        }

        [HttpPost]
        public async Task<IActionResult> Update(PaymentNameDto paymentNameDto)
        {
            if (ModelState.IsValid)
            {
                await _service.UpdateAsync(_mapper.Map<PaymentName>(paymentNameDto));
                return RedirectToAction(nameof(Index));
            }
            return View(paymentNameDto);
        }

        public async Task<IActionResult> Remove(int id)
        {
            PaymentName paymentName = await _service.GetByNoTrackIdAsync(id);

            await _service.RemoveAsync(paymentName);
            return RedirectToAction(nameof(Index));

        }
    }
}
