using FinancialManager.Validators;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace FinancialManager.ViewModels
{
    internal class BankBalanceViewModel : BindableBase
    {
        private readonly BankValidator validator;
        private ObservableCollection<ValidationResult> validation;


        public BankBalanceViewModel()
        {
            validator = new BankValidator();
            SaveCommand = new DelegateCommand(Save, CanSave);
            InclusionDate = DateTime.Now;
        }

        private int code;
        public int Code
        {
            get { return code; }
            set { SetProperty(ref code, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private decimal bankBalance;
        public decimal BankBalance
        {
            get { return bankBalance; }
            set { SetProperty(ref bankBalance, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private bool active;
        public bool Active
        {
            get { return active; }
            set { SetProperty(ref active, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private DateTime inclusionDate;
        public DateTime InclusionDate
        {
            get { return inclusionDate; }
            set { SetProperty(ref inclusionDate, value); }
        }

        public ObservableCollection<ValidationResult> Validation
        {
            get { return validation; }
            set { SetProperty(ref validation, value); }
        }


        public DelegateCommand SaveCommand { get; private set; }

        private bool CanSave()
        {
            Validation = new ObservableCollection<ValidationResult>();
            ValidationResult result = validator.Validate(this);
            Validation.Add(result);
            return result.IsValid;
        }

        private void Save()
        {
            //Code to save the company object to the database
        }
    }
}
