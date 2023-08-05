using System;

namespace FinancialManager.Dtos
{
    public class BankDto
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public decimal BankBalance { get; set; }
        public bool Active { get; set; }
        public DateTime InclusionDate { get; set; }
    }
}
