using FluentValidation;
using Project.Core.DTOs;

namespace Project.Service.Validations
{
	public class PaymentDetailValidator : AbstractValidator<PaymentDetailDto>
	{
		public PaymentDetailValidator()
		{
			RuleFor(x => x.PaymentName).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
			RuleFor(x => x.Price).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater then 0");			

		}
	}
}
