using FinancialManager.Dtos;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace FinancialManager.ViewModels
{
    public class BankBalanceDetailsViewModel : BindableBase
    {
        private ObservableCollection<BankDto> bankDtos;

        public ObservableCollection<BankDto> BankDtos
        {
            get { return bankDtos; }
            set { SetProperty(ref bankDtos, value); }
        }

        public DelegateCommand<BankDto> DeleteBankCommand { get; }
        public DelegateCommand<BankDto> UpdateBankCommand { get; }

        public BankBalanceDetailsViewModel()
        {
            BankDtos = new ObservableCollection<BankDto>()
        {
               new BankDto()
            {
                Code = 1234,
                Name = "HSBC Bank",
                BankBalance = 5000000.00m,
                Active = true,
                InclusionDate = new DateTime(2023, 7, 25)
            },
            new BankDto()
            {
                Code = 5678,
                Name = "Barclays Bank",
                BankBalance = 4000000.00m,
                Active = true,
                InclusionDate = new DateTime(2023, 7, 26)
            },
            new BankDto()
            {
                Code = 9101,
                Name = "Lloyds Bank",
                BankBalance = 3500000.00m,
                Active = true,
                InclusionDate = new DateTime(2023, 7, 27)
            },
            new BankDto()
            {
                Code = 2345,
                Name = "Royal Bank of Scotland",
                BankBalance = 4500000.00m,
                Active = true,
                InclusionDate = new DateTime(2023, 7, 28)
            },
            new BankDto()
            {
                Code = 6789,
                Name = "NatWest Bank",
                BankBalance = 3800000.00m,
                Active = true,
                InclusionDate = new DateTime(2023, 7, 29)
            },
        };

            DeleteBankCommand = new DelegateCommand<BankDto>(DeleteBank);
            UpdateBankCommand = new DelegateCommand<BankDto>(UpdateBank);
        }

        private void DeleteBank(BankDto Bank)
        {
            BankDtos.Remove(Bank);
        }

        private void UpdateBank(BankDto Bank)
        {
            //Implement update to data base
        }
    }
}
