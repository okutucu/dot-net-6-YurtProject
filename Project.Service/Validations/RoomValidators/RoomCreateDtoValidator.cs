using FluentValidation;
using Project.Core.DTOs;

namespace Project.Service.Validations.RoomValidators
{
	public class RoomCreateDtoValidator : AbstractValidator<RoomCreateDto>
	{
		public RoomCreateDtoValidator()
		{
			RuleFor(x => x.RoomName).NotNull().WithMessage("{PropertyName} is a required").NotEmpty().WithMessage("(PropertyName) is required");
			RuleFor(x => x.Capacity).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater then 0");
		}
	}
}
