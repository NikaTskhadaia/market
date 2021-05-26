using System;

namespace Market.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public bool IsActive { get; set; }
    }
}
