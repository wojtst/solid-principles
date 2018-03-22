using System;

namespace SolidPrinciples.Ocp.Step1
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public DateTime EmploymentDay { get; set; }
        public string PhoneNumber { get; set; }
    }
}