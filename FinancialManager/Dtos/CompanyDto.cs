using System;

namespace FinancialManager.Dtos
{
    public class CompanyDto
    {
        public string Name { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? FoundedDate { get; set; }
        public string Employees { get; set; }
        public string Industry { get; set; }
        public AddressDto Address { get; set; }
    }
}
