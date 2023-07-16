using FinancialManager.Validators;
using FinancialManager.Views;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace FinancialManager.ViewModels
{
    internal class CompanyViewModel : BindableBase
    {
        private readonly CompanyViewModelValidator validator;
        private ObservableCollection<ValidationResult> validation;
        private ObservableCollection<string> industries;
        private AdressView _adressView;
        private string name;
        private string website;
        private string phone;
        private string email;
        private System.DateTime? foundedDate;
        private string employees;
        private string industry;

        public CompanyViewModel()
        {
            SaveCommand = new DelegateCommand(Save, CanSave);
            AdressView = new AdressView(SaveCommand);
            validator = new CompanyViewModelValidator();
            Industries = new ObservableCollection<string>(GetIndustries());
        }

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        public string Website
        {
            get { return website; }
            set { SetProperty(ref website, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        public string Phone
        {
            get { return phone; }
            set { SetProperty(ref phone, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        public System.DateTime? FoundedDate
        {
            get { return foundedDate; }
            set { SetProperty(ref foundedDate, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        public string Employees
        {
            get { return employees; }
            set { SetProperty(ref employees, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        public string Industry
        {
            get { return industry; }
            set { SetProperty(ref industry, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        public ObservableCollection<string> Industries
        {
            get { return industries; }
            set { SetProperty(ref industries, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        public AdressView AdressView
        {
            get { return _adressView; }
            set { SetProperty(ref _adressView, value); }
        }

        public ObservableCollection<ValidationResult> Validation
        {
            get { return validation; }
            set { SetProperty(ref validation, value); }
        }

        public List<string> GetIndustries()
        {
            List<string> industries = new List<string>()
            {
                "Finance",
                "Technology",
                "Consulting",
                "Healthcare",
                "Media",
                "Retail",
                "Hospitality",
                "Education",
                "Transportation",
                "Real Estate",
                "Legal",
                "Energy",
                "Manufacturing",
                "Construction",
                "Automotive",
                "Telecommunications",
                "Pharmaceuticals",
                "Insurance",
                "Government",
                "Non-profit",
                "Others"
            };

            return industries;
        }

        public DelegateCommand SaveCommand { get; private set; }

        private bool CanSave()
        {
            Validation = new ObservableCollection<ValidationResult>();
            ValidationResult result = validator.Validate(this);
            AdressView.ViewModel.AnalizeObject();
            Validation.Add(result);
            Validation.Add(AdressView.ViewModel.ValidationResult);
            return result.IsValid && AdressView.ViewModel.ValidationResult.IsValid;
        }

        private void Save()
        {
            // Implement the logic to save the data to the database here
            // Use the properties Name, Website, Phone, Email, FoundedDate, Employees, and Industry

            // Example:
            // var company = new Company
            // {
            //     Name = Name,
            //     Website = Website,
            //     Phone = Phone,
            //     Email = Email,
            //     FoundedDate = FoundedDate,
            //     Employees = Employees,
            //     Industry = Industry
            // };
            //
            // // Code to save the company object to the database
        }
    }
}
