using FinancialManager.Validators;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace FinancialManager.ViewModels
{
    internal class TransactionViewModel : BindableBase
    {
        private readonly TransactionsViewModelValidator _validator;
        private ObservableCollection<ValidationResult> _validation;

        public TransactionViewModel()
        {
            Validation = new ObservableCollection<ValidationResult>();
            SaveCommand = new DelegateCommand(Save, CanSave);
            _validator = new TransactionsViewModelValidator();
        }
        public ObservableCollection<ValidationResult> Validation
        {
            get { return _validation; }
            set { SetProperty(ref _validation, value); }
        }

        private long _id;
        public long Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private int _relationshipId;
        public int RelationshipId
        {
            get { return _relationshipId; }
            set { SetProperty(ref _relationshipId, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private string _relationshipName;
        public string RelationshipName
        {
            get { return _relationshipName; }
            set { SetProperty(ref _relationshipName, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private decimal _value;
        public decimal Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private string _status;
        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private string _note;
        public string Note
        {
            get { return _note; }
            set { SetProperty(ref _note, value); }
        }

        private DateTime? _emissionDate;
        public DateTime? EmissionDate
        {
            get { return _emissionDate; }
            set { SetProperty(ref _emissionDate, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private DateTime? _expectedPaymentDate;
        public DateTime? ExpectedPaymentDate
        {
            get { return _expectedPaymentDate; }
            set { SetProperty(ref _expectedPaymentDate, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private DateTime? _paymentDate;
        public DateTime? PaymentDate
        {
            get { return _paymentDate; }
            set { SetProperty(ref _paymentDate, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        public DelegateCommand SaveCommand { get; private set; }

        private bool CanSave()
        {
            Validation = new();
            ValidationResult result = _validator.Validate(this);
            Validation.Add(result);
            return result.IsValid;
        }

        private void Save()
        {
            // Here you can implement the logic to save the data in the database
            // Use the properties Name, NIN, Phone, Email, DateOfBirth, Gender, and Nationality
            // Example:
            // var transactionDto = new TransactionDto
            // // Code to save the individual object in the database
        }
    }
}
