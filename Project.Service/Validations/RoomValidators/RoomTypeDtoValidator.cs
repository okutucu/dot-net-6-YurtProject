using FluentValidation;
using Project.Core.DTOs;

namespace Project.Service.Validations.RoomValidators
{
	public class RoomTypeDtoValidator : AbstractValidator<RoomTypeDto>
	{
		public RoomTypeDtoValidator()
		{
			RuleFor(x => x.RoomName).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
			RuleFor(x => x.Price).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater then 0");
			RuleFor(x => x.IncreasedPrice).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater then 0");
		}

	}
}
