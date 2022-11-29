using FluentValidation;
using Project.Core.DTOs;

namespace Project.Service.Validations
{
    public class PaymentNameValidator : AbstractValidator<PaymentNameDto>
    {
        public PaymentNameValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");

        }
    }
}
