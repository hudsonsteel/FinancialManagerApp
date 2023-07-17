using FinancialManager.Validators;
using FinancialManager.Views;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace FinancialManager.ViewModels
{
    internal class IndividualsViewModel : BindableBase
    {
        private readonly IndividualsViewModelValidator validator;
        private AdressView _adressView;
        private ObservableCollection<ValidationResult> validation;
        private string name;
        private string nin;
        private string phone;
        private DateTime? dateOfBirth;
        private string email;
        private string gender;
        private ObservableCollection<string> nationalities;
        private string nationality;

        public IndividualsViewModel()
        {
            Validation = new ObservableCollection<ValidationResult>();
            SaveCommand = new DelegateCommand(Save, CanSave);
            AdressView = new AdressView(SaveCommand);
            validator = new IndividualsViewModelValidator();
            Nationalities = new ObservableCollection<string>(GetNationalities());
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

        public string Name
        {
            get { return name; }
            set
            {
                SetProperty(ref name, value);
                SaveCommand.RaiseCanExecuteChanged();
            }
        }
        public string NIN
        {
            get { return nin; }
            set { SetProperty(ref nin, value); SaveCommand.RaiseCanExecuteChanged(); }
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

        public DateTime? DateOfBirth
        {
            get { return dateOfBirth; }
            set { SetProperty(ref dateOfBirth, value); SaveCommand.RaiseCanExecuteChanged(); }
        }
        public string Gender
        {
            get { return gender; }
            set { SetProperty(ref gender, value); SaveCommand.RaiseCanExecuteChanged(); }
        }
        public ObservableCollection<string> Nationalities
        {
            get { return nationalities; }
            set { SetProperty(ref nationalities, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        public string Nationality
        {
            get { return nationality; }
            set { SetProperty(ref nationality, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        /// <summary>
        /// Retrieve all nationalities from a database or API
        /// </summary>
        /// <returns></returns>
        public List<string> GetNationalities()
        {
            List<string> nationalities = new List<string>()
        {
            "Germany",
            "France",
            "Italy",
            "Spain",
            "Mexico",
            "Russia",
            "Brazil",
            "South Africa",
            "Netherlands",
            "China",
            "India",
            "Japan",
            "South Korea",
            "Indonesia",
            "Vietnam",
            "Thailand",
            "Pakistan",
            "Philippines",
            "Bangladesh",
            "Iran",
            "Turkey",
            "Iraq",
            "Saudi Arabia",
            "UAE (United Arab Emirates)",
            "Israel",
            "Lebanon",
            "Jordan",
            "Kuwait",
            "Oman",
            "Qatar",
            "Bahrain",
            "United States",
            "United Kingdom",
            "Canada",
            "Australia",
            "Germany",
            "France",
            "Italy",
            "Spain",
            "China",
            "Japan",
            "India",
            "Mexico",
            "Russia",
            "Brazil",
            "South Africa",
            "Netherlands"
        };

            return nationalities;
        }

        public DelegateCommand SaveCommand { get; private set; }
        private bool CanSave()
        {
            Validation = new();
            ValidationResult result = validator.Validate(this);
            AdressView.ViewModel.AnalizeObject();
            Validation.Add(result);
            Validation.Add(AdressView.ViewModel.ValidationResult);
            return result.IsValid && AdressView.ViewModel.ValidationResult.IsValid;
        }
        private void Save()
        {
            // Here you can implement the logic to save the data in the database
            // Use the properties Name, NIN, Phone, Email, DateOfBirth, Gender, and Nationality
            // Example:
            // var individual = new Individual
            // {
            //     Name = Name,
            //     NIN = NIN,
            //     Phone = Phone,
            //     Email = Email,
            //     DateOfBirth = DateOfBirth,
            //     Gender = Gender,
            //     Nationality = Nationality
            // };
            //
            // // Code to save the individual object in the database

        }

    }

}
