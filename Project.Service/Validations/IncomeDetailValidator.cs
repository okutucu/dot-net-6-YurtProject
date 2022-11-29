using FluentValidation;
using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Service.Validations
{
	public class IncomeDetailValidator : AbstractValidator<IncomeDetailDto>
	{
		public IncomeDetailValidator()
		{
			RuleFor(x => x.Price).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater then 0");
			RuleFor(x => x.RoomId).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
		}
	}
}
