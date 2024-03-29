﻿using FluentValidation;
using Project.Core.DTOs;

namespace Project.Service.Validations
{
    public class RoomIncomeValidator : AbstractValidator<RoomIncomeDto>
    {
        public RoomIncomeValidator()
        {
            RuleFor(x => x.Price).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater then 0");
            RuleFor(x => x.Exchange).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
        }
    }
}
