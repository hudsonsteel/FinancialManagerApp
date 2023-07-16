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

        private string _street;
        public string Street
        {
            get { return _street; }
            set { SetProperty(ref _street, value); ValidatorCommand.RaiseCanExecuteChanged(); }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { SetProperty(ref _city, value); ValidatorCommand.RaiseCanExecuteChanged(); }
        }

        private string _state;
        public string State
        {
            get { return _state; }
            set { SetProperty(ref _state, value); ValidatorCommand.RaiseCanExecuteChanged(); }
        }

        private string _postalCode;
        public string PostalCode
        {
            get { return _postalCode; }
            set { SetProperty(ref _postalCode, value); ValidatorCommand.RaiseCanExecuteChanged(); }
        }

        private string _country;
        public string Country
        {
            get { return _country; }
            set { SetProperty(ref _country, value); ValidatorCommand.RaiseCanExecuteChanged(); }
        }

        private string _additionalFields;
        public string AdditionalFields
        {
            get { return _additionalFields; }
            set { SetProperty(ref _additionalFields, value); ValidatorCommand.RaiseCanExecuteChanged(); }
        }
    }
}
