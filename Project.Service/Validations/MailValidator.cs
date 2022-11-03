using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Project.Core.DTOs;

namespace Project.Service.Validations
{
    public class MailValidator : AbstractValidator<MailDto>
    {
        public MailValidator()
        {
            // todo multiple post 
            //RuleFor(x => x.Body).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
            //RuleFor(x => x.Subject).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
        }
    }
}
