using FluentValidation;
using Project.Core.DTOs;

namespace Project.Service.Validations.CustomerValidators
{
	public class CustomerDtoValidator : AbstractValidator<CustomerDto>
	{
		public CustomerDtoValidator()
		{
			RuleFor(x => x.FullName).NotNull().WithMessage("{PropertyName} is a required").NotEmpty().WithMessage("(PropertyName) is a required");
			RuleFor(x => x.EntryDate).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
			RuleFor(x => x.Email).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
            RuleFor(x => x.DownPaymentPrice).InclusiveBetween(0, int.MaxValue).WithMessage("{PropertyName} must be a number");
            RuleFor(x => x.DiscountPrice).InclusiveBetween(0, int.MaxValue).WithMessage("{PropertyName} must be a number");
        }
	}
}
