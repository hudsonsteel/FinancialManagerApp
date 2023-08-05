using FinancialManager.Dtos;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace FinancialManager.ViewModels
{
    public class TransactionDetailsViewModel : BindableBase
    {
        private ObservableCollection<TransactionDto> transactionDtos;

        public ObservableCollection<TransactionDto> TransactionDtos
        {
            get { return transactionDtos; }
            set { SetProperty(ref transactionDtos, value); }
        }
        private ObservableCollection<string> statusOptions;
        public ObservableCollection<string> StatusOptions
        {
            get { return statusOptions; }
            set { SetProperty(ref statusOptions, value); }
        }

        public DelegateCommand<TransactionDto> DeleteTransactionCommand { get; }
        public DelegateCommand<TransactionDto> UpdateTransactionCommand { get; }

        public TransactionDetailsViewModel()
        {
            TransactionDtos = new ObservableCollection<TransactionDto>()
            {
                new TransactionDto()
                {
                    Id = 1,
                    Description = "Purchase of office supplies",
                    RelationshipId = 12345,
                    RelationshipName = "London Office Supplies Ltd.",
                    Value = 250.50m,
                    Status = "Pending",
                    Note = "Awaiting approval",
                    EmissionDate = new DateTime(2023, 7, 15),
                    ExpectedPaymentDate = new DateTime(2023, 7, 30),
                    PaymentDate = null // No payment made yet
                },
                new TransactionDto()
                {
                    Id = 2,
                    Description = "Sale of products",
                    RelationshipId = 54321,
                    RelationshipName = "London Tech Solutions Ltd.",
                    Value = 1200.00m,
                    Status = "Paid",
                    Note = "Payment received",
                    EmissionDate = new DateTime(2023, 7, 20),
                    ExpectedPaymentDate = new DateTime(2023, 7, 30),
                    PaymentDate = new DateTime(2023, 7, 25)
                },
            };
            StatusOptions = new ObservableCollection<string>()
            {
                "Payment Delayed",
                "Within Deadline",
                "Canceled",
                "Received",
                "Paid"
            };
            DeleteTransactionCommand = new DelegateCommand<TransactionDto>(DeleteTransaction);
            UpdateTransactionCommand = new DelegateCommand<TransactionDto>(UpdateTransaction);
        }

        private void DeleteTransaction(TransactionDto Transaction)
        {
            TransactionDtos.Remove(Transaction);
        }

        private void UpdateTransaction(TransactionDto Transaction)
        {
            //Implement update to database
        }
    }
}
