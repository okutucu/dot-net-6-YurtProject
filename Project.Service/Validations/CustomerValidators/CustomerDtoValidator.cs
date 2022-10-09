using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
