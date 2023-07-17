using FinancialManager.Validators;
using Prism.Commands;
using Prism.Mvvm;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace FinancialManager.ViewModels
{
    public class AdressViewModel : BindableBase
    {
        private AdressViewValidator _validator;
        public ValidationResult ValidationResult { get; private set; }
        public DelegateCommand ValidatorCommand { get; private set; }

        public AdressViewModel()
        {
            ValidationResult = new ValidationResult();
        }
        public AdressViewModel(DelegateCommand delegateCommand) : this()
        {
            ValidatorCommand = delegateCommand;
        }
        public void AnalizeObject()
        {
            _validator = new();
            ValidationResult = _validator.Validate(this);
        }

        private string _city;
        private string _state;
        private string _postalCode;
        private string _street;
        private string _additionalFields;
        private string _country;

        public string Street
        {
            get { return _street; }
            set { SetProperty(ref _street, value); ValidatorCommand?.RaiseCanExecuteChanged(); }
        }

        public string City
        {
            get { return _city; }
            set { SetProperty(ref _city, value); ValidatorCommand?.RaiseCanExecuteChanged(); }
        }

        public string State
        {
            get { return _state; }
            set { SetProperty(ref _state, value); ValidatorCommand?.RaiseCanExecuteChanged(); }
        }

        public string PostalCode
        {
            get { return _postalCode; }
            set { SetProperty(ref _postalCode, value); ValidatorCommand?.RaiseCanExecuteChanged(); }
        }

        public string Country
        {
            get { return _country; }
            set { SetProperty(ref _country, value); ValidatorCommand?.RaiseCanExecuteChanged(); }
        }

        public string AdditionalFields
        {
            get { return _additionalFields; }
            set { SetProperty(ref _additionalFields, value); ValidatorCommand?.RaiseCanExecuteChanged(); }
        }
    }
}
