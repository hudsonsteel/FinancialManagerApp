using System;

namespace FinancialManager.Dtos
{
    public class TransactionDto
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public int RelationshipId { get; set; }
        public string RelationshipName { get; set; }
        public decimal Value { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public DateTime? EmissionDate { get; set; }
        public DateTime? ExpectedPaymentDate { get; set; }
        public DateTime? PaymentDate { get; set; }
    }

}
