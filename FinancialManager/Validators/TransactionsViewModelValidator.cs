using FinancialManager.ViewModels;
using FluentValidation;

namespace FinancialManager.Validators
{
    internal class TransactionsViewModelValidator : AbstractValidator<TransactionViewModel>
    {
        public TransactionsViewModelValidator()
        {
            RuleFor(vm => vm.Id)
                .NotEmpty()
                .WithMessage("Id is required.");

            RuleFor(vm => vm.Description)
                .NotEmpty().WithMessage("Description is required.");

            RuleFor(vm => vm.RelationshipId)
                .NotEmpty().WithMessage("RelationshipId is required.");

            RuleFor(vm => vm.RelationshipName)
                .NotEmpty().WithMessage("RelationshipName is required.");

            RuleFor(vm => vm.Value)
               .NotEmpty().WithMessage("Value is required.");

            RuleFor(vm => vm.Status)
              .NotEmpty().WithMessage("Status is required.");

            RuleFor(vm => vm.EmissionDate)
                .NotEmpty().WithMessage("EmissionDate is required.");

            RuleFor(vm => vm.ExpectedPaymentDate)
                .NotEmpty().WithMessage("ExpectedPaymentDate is required.");
        }
    }
}
