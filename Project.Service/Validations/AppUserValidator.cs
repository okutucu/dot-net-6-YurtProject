using FluentValidation;
using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Service.Validations
{
	public class AppUserValidator : AbstractValidator<AppUserDto>
	{
		public AppUserValidator()
		{
			RuleFor(x => x.UserName).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
			RuleFor(x => x.Password).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
		}
	}
}
