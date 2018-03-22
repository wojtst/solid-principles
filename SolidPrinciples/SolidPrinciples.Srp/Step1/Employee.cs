using System;
using System.Text;

namespace SolidPrinciples.Srp.Step1
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public DateTime EmploymentDay { get; set; }
        public string PhoneNumber { get; set; }

        public string GetEmployeeDescription()
        {
            string jobTitle;

            var employmentTimeInDays = (DateTime.Now - EmploymentDay).TotalDays;

            if (employmentTimeInDays > 3600)
            {
                jobTitle = "Ninja";
            }
            else if (employmentTimeInDays > 1800)
            {
                jobTitle = "Expert";
            }
            else if (employmentTimeInDays > 1080)
            {
                jobTitle = "Senior";
            }
            else if (employmentTimeInDays > 540)
            {
                jobTitle = "Regular";
            }
            else
            {
                jobTitle = "Junior";
            }

            var builder = new StringBuilder();

            builder.AppendLine($"{jobTitle} {FirstName} {LastName}");
            builder.AppendLine($"Contact: {Email}");

            return builder.ToString().Trim();
        }

        public decimal CalculatePayment()
        {
            var employmentTime = DateTime.Now - EmploymentDay;

            if (employmentTime.TotalDays > 180)
            {
                return Salary * 2;
            }

            return Salary;
        }

        public void SendNotificationEmail(Message message)
        {
            // send e-mail to the employee
        }
    }
}