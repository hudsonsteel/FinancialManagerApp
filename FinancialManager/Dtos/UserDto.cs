using System;

namespace FinancialManager.Dtos
{
    public class UserDto
    {
        public string Name { get; set; }

        public string NIN { get; set; }

        public string Phone { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public string Nationality { get; set; }

        public AddressDto Address { get; set; }

    }
}
