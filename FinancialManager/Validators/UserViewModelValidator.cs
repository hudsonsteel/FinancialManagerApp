using FinancialManager.ViewModels;
using FluentValidation;

namespace FinancialManager.Validators
{
    internal class UserViewModelValidator : AbstractValidator<UsersViewModel>
    {
        public UserViewModelValidator()
        {
            RuleFor(vm => vm.Name)
                .NotEmpty().WithMessage("Name is required.");

            RuleFor(vm => vm.NIN)
                .NotEmpty().WithMessage("NIN is required.");

            RuleFor(vm => vm.Phone)
                .NotEmpty().WithMessage("Phone is required.");

            RuleFor(vm => vm.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email address.");

            RuleFor(vm => vm.DateOfBirth)
                .NotEmpty().WithMessage("Date of Birth is required.");

            RuleFor(vm => vm.Gender)
                .NotEmpty().WithMessage("Gender is required.");

            RuleFor(vm => vm.Nationality)
                .NotEmpty().WithMessage("Nationality is required.");
        }
    }

}
