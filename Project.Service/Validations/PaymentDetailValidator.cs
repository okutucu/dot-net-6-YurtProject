using FluentValidation;
using Project.Core.DTOs;

namespace Project.Service.Validations
{
	public class PaymentDetailValidator : AbstractValidator<PaymentDetailDto>
	{
		public PaymentDetailValidator()
		{
			RuleFor(x => x.Price).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater then 0");			

		}
	}
}
