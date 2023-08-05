using FinancialManager.ViewModels;
using FluentValidation;
using System;

namespace FinancialManager.Validators
{
    internal class BankValidator : AbstractValidator<BankBalanceViewModel>
    {
        public BankValidator()
        {
            RuleFor(vm => vm.Code)
                .GreaterThan(0).WithMessage("Code must be greater than zero.");

            RuleFor(vm => vm.Name)
           .NotEmpty().WithMessage("Name is required.");

            RuleFor(vm => vm.BankBalance)
                .GreaterThanOrEqualTo(0).WithMessage("Bank balance must be non-negative.");

            RuleFor(vm => vm.InclusionDate)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Inclusion date cannot be in the future.");
        }
    }
}
