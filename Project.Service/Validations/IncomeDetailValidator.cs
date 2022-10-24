using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Project.Core.Models;

namespace Project.Service.Validations
{
	public class IncomeDetailValidator : AbstractValidator<IncomeDetail>
	{
		public IncomeDetailValidator()
		{
            RuleFor(x => x.PaymentName).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
            RuleFor(x => x.Price).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater then 0");
            RuleFor(x => x.Exchange).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
            RuleFor(x => x.PaymentMethod).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
            RuleFor(x => x.RoomId).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
        }
	}
}
