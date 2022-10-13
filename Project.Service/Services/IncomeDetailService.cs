using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Project.Core.DTOs;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;
using Project.Repository.Repositories;

namespace Project.Service.Services
{
	public class IncomeDetailService : Service<IncomeDetail>, IIncomeDetailService
	{
		private readonly IIncomeDetailRepository _incomeDetailRepository;
        private readonly IMapper _mapper;


		public IncomeDetailService(IUnitOfWork unitOfWok, IGenericRepository<IncomeDetail> repository, IIncomeDetailRepository incomeDetailRepository, IMapper mapper) : base(unitOfWok, repository)
		{
            _incomeDetailRepository = incomeDetailRepository;
            _mapper = mapper;
        }

		public async Task<List<IncomeDetailDto>> GetIncomeWithRoomAsync()
		{
			List<IncomeDetail> incomeDetails = await _incomeDetailRepository.GetIncomeWithRoomAsync();

			List<IncomeDetailDto> incomeDetailsDto = _mapper.Map<List<IncomeDetailDto>>(incomeDetails);

			return incomeDetailsDto;

        }
	}
}
