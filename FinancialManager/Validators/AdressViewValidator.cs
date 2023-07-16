using FinancialManager.ViewModels;
using FluentValidation;

namespace FinancialManager.Validators
{
    public class AdressViewValidator : AbstractValidator<AdressViewModel>
    {
        public AdressViewValidator()
        {
            RuleFor(x => x.Street).NotEmpty().WithMessage("Street is required");
            RuleFor(x => x.City).NotEmpty().WithMessage("City is required");
            RuleFor(x => x.State).NotEmpty().WithMessage("State/Province is required");
            RuleFor(x => x.PostalCode).NotEmpty().WithMessage("Postal Code is required");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Country is required");
            RuleFor(x => x.AdditionalFields).NotEmpty().WithMessage("Additional Fields is required");
        }
    }
}
