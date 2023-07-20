using FinancialManager.Dtos;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace FinancialManager.ViewModels
{
    public class UserDetailsViewModel : BindableBase
    {
        private ObservableCollection<IndividualDto> individualDtos;

        public ObservableCollection<IndividualDto> IndividualDtos
        {
            get { return individualDtos; }
            set { SetProperty(ref individualDtos, value); }
        }

        public DelegateCommand<IndividualDto> DeleteIndividualCommand { get; }
        public DelegateCommand<IndividualDto> UpdateIndividualCommand { get; }

        public UserDetailsViewModel()
        {
            IndividualDtos = new ObservableCollection<IndividualDto>()
            {
                new IndividualDto()
                {
                    Name = "Jane Smith",
                    NIN = "987654321",
                    Phone = "987-654-3210",
                    DateOfBirth = new DateTime(1995, 5, 10),
                    Email = "jane.smith@example.com",
                    Gender = "Female",
                    Nationality = "UK",
                    Address = new AddressDto
                    {
                        AdditionalFields = "Apt 3B",
                        City = "London",
                        Country = "United Kingdom",
                        PostalCode = "SW1A 1AA",
                        State = "England",
                        Street = "123 Main Street"
                    }
                },

                new IndividualDto()
                {
                    Name = "Robert Johnson",
                    NIN = "543216789",
                    Phone = "543-216-7890",
                    DateOfBirth = new DateTime(1985, 3, 15),
                    Email = "robert.johnson@example.com",
                    Gender = "Male",
                    Nationality = "USA",
                    Address = new AddressDto
                    {
                        AdditionalFields = "Floor 4",
                        City = "New York",
                        Country = "USA",
                        PostalCode = "10001",
                        State = "New York",
                        Street = "456 Oak Avenue"
                    }
                },

                new IndividualDto()
                {
                    Name = "Maria Garcia",
                    NIN = "123459876",
                    Phone = "123-459-8760",
                    DateOfBirth = new DateTime(1992, 9, 20),
                    Email = "maria.garcia@example.com",
                    Gender = "Female",
                    Nationality = "Spain",
                    Address = new AddressDto
                    {
                        AdditionalFields = "Unit 2",
                        City = "Madrid",
                        Country = "Spain",
                        PostalCode = "28001",
                        State = "Madrid",
                        Street = "789 Elm Street"
                    }
                },

                new IndividualDto()
                {
                    Name = "Alexandre Silva",
                    NIN = "456789123",
                    Phone = "456-789-1230",
                    DateOfBirth = new DateTime(1988, 7, 8),
                    Email = "alexandre.silva@example.com",
                    Gender = "Male",
                    Nationality = "Brazil",
                    Address = new AddressDto
                    {
                        AdditionalFields = "Block C",
                        City = "São Paulo",
                        Country = "Brazil",
                        PostalCode = "01234-567",
                        State = "São Paulo",
                        Street = "987 Pine Avenue"
                    }
                }
            };

            DeleteIndividualCommand = new DelegateCommand<IndividualDto>(DeleteIndividual);
            UpdateIndividualCommand = new DelegateCommand<IndividualDto>(UpdateIndividual);
        }

        private void DeleteIndividual(IndividualDto individual)
        {
            IndividualDtos.Remove(individual);
        }

        private void UpdateIndividual(IndividualDto individual)
        {
            // Implemente o código para enviar o objeto individual atualizado para o controlador aqui.
            // individual contém os dados atualizados.
        }
    }
}
