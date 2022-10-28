using FluentValidation;
using Project.Core.Models;

namespace Project.Service.Validations
{
	public class AppUserValidator : AbstractValidator<AppUser>
	{
		public AppUserValidator()
		{
			RuleFor(x => x.UserName).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
			RuleFor(x => x.Password).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("(PropertyName) is required");
		}
	}
}
