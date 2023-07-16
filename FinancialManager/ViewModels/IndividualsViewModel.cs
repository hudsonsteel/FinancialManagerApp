using FinancialManager.Validators;
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

        public IndividualsViewModel()
        {
            Validation = new ObservableCollection<ValidationResult>();
            SaveCommand = new DelegateCommand(Save, CanSave);
            validator = new IndividualsViewModelValidator();
            Nationalities = new ObservableCollection<string>(GetNationalities());

        }


        private void UpdateValidation(ValidationResult result)
        {
            Validation = new ObservableCollection<ValidationResult> { result };
        }

        private ObservableCollection<ValidationResult> validation;
        public ObservableCollection<ValidationResult> Validation
        {
            get { return validation; }
            set { SetProperty(ref validation, value); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                SetProperty(ref name, value);
                SaveCommand.RaiseCanExecuteChanged();
            }
        }
        private string nin;
        public string NIN
        {
            get { return nin; }
            set { SetProperty(ref nin, value); SaveCommand.RaiseCanExecuteChanged(); }
        }
        private string phone;
        public string Phone
        {
            get { return phone; }
            set { SetProperty(ref phone, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private DateTime? dateOfBirth;
        public DateTime? DateOfBirth
        {
            get { return dateOfBirth; }
            set { SetProperty(ref dateOfBirth, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set { SetProperty(ref gender, value); SaveCommand.RaiseCanExecuteChanged(); }
        }
        private ObservableCollection<string> nationalities;
        public ObservableCollection<string> Nationalities
        {
            get { return nationalities; }
            set { SetProperty(ref nationalities, value); SaveCommand.RaiseCanExecuteChanged(); }
        }

        private string nationality;
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
            Validation.Add(result);
            return result.IsValid;
        }
        private void Save()
        {
            // Aqui você pode implementar a lógica para salvar os dados no banco de dados
            // Utilize as propriedades Name, NIN, Phone, Email, DateOfBirth, Gender e Nationality

            // Exemplo:
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
            // // Código para salvar o objeto individual no banco de dados
        }

    }

}
