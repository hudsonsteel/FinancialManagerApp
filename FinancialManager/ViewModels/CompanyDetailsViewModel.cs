using FinancialManager.Dtos;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace FinancialManager.ViewModels
{
    public class CompanyDetailsViewModel : BindableBase
    {
        private ObservableCollection<CompanyDto> companyDtos;

        public ObservableCollection<CompanyDto> CompanyDtos
        {
            get { return companyDtos; }
            set { SetProperty(ref companyDtos, value); }
        }

        public DelegateCommand<CompanyDto> DeleteCompanyCommand { get; }
        public DelegateCommand<CompanyDto> UpdateCompanyCommand { get; }

        public CompanyDetailsViewModel()
        {
            CompanyDtos = new ObservableCollection<CompanyDto>()
        {
            new CompanyDto()
            {
                Name = "ABC Corp",
                Website = "www.abccorp.com",
                Phone = "+44 20 1234 5678",
                Email = "contact@abccorp.com",
                FoundedDate = new DateTime(1990, 6, 15),
                Employees = "500",
                Industry = "Technology",
                Address = new AddressDto
                {
                    AdditionalFields = "Floor 5",
                    City = "London",
                    Country = "United Kingdom",
                    PostalCode = "WC1A 1AA",
                    State = "England",
                    Street = "123 Oxford Street"
                }
            },

            new CompanyDto()
            {
                Name = "XYZ Ltd",
                Website = "www.xyzltd.com",
                Phone = "+44 20 9876 5432",
                Email = "info@xyzltd.com",
                FoundedDate = new DateTime(1985, 9, 20),
                Employees = "200",
                Industry = "Finance",
                Address = new AddressDto
                {
                    AdditionalFields = "Suite 10",
                    City = "London",
                    Country = "United Kingdom",
                    PostalCode = "EC2V 7NQ",
                    State = "England",
                    Street = "456 Bishopsgate"
                }
            },

            new CompanyDto()
            {
                Name = "London Fashion Co.",
                Website = "www.londonfashionco.com",
                Phone = "+44 20 7654 3210",
                Email = "info@londonfashionco.com",
                FoundedDate = new DateTime(2000, 3, 5),
                Employees = "300",
                Industry = "Fashion",
                Address = new AddressDto
                {
                    AdditionalFields = "Shop 25",
                    City = "London",
                    Country = "United Kingdom",
                    PostalCode = "W1F 8AH",
                    State = "England",
                    Street = "789 Regent Street"
                }
            },

            new CompanyDto()
            {
                Name = "GreenTech Solutions",
                Website = "www.greentechsolutions.com",
                Phone = "+44 20 3456 7890",
                Email = "contact@greentechsolutions.com",
                FoundedDate = new DateTime(2008, 12, 10),
                Employees = "1000",
                Industry = "Renewable Energy",
                Address = new AddressDto
                {
                    AdditionalFields = "Unit 3",
                    City = "London",
                    Country = "United Kingdom",
                    PostalCode = "SW7 1NA",
                    State = "England",
                    Street = "987 Kensington High Street"
                }
            }
        };

            DeleteCompanyCommand = new DelegateCommand<CompanyDto>(DeleteCompany);
            UpdateCompanyCommand = new DelegateCommand<CompanyDto>(UpdateCompany);
        }

        private void DeleteCompany(CompanyDto Company)
        {
            CompanyDtos.Remove(Company);
        }

        private void UpdateCompany(CompanyDto Company)
        {
            // Implemente o código para enviar o objeto Company atualizado para o controlador aqui.
            // Company contém os dados atualizados.
        }
    }
}
