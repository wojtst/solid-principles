using System;
using System.Text;

namespace SolidPrinciples.Srp.Step0
{
    public class EmployeeEscalated
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

        public string GetEnglishEmployeeDescription()
        {
            return FirstName;
        }

        public string GetElvishEmployeeDescription()
        {
            return FirstName;
        }

        public string GetSpanishEmployeeDescription()
        {
            return FirstName;
        }

        public decimal CalculateCorpoRatPayment()
        {
            return 0;
        }

        public decimal CalculateRegularPayment()
        {
            var employmentTime = DateTime.Now - EmploymentDay;

            if (employmentTime.TotalDays > 180)
            {
                return Salary * 2;
            }

            return Salary;
        }

        public decimal CalculateManagerPayment()
        {
            return Salary * 10;
        }

        public decimal CalculateCeoPayment()
        {
            return decimal.MaxValue;
        }

        public EmployeeEscalated GetById(Guid id)
        {
            // get a client from some data source
            return this;
        }

        public EmployeeEscalated GetFromFile(string path)
        {
            return this;
        }

        public void SaveInDatabase()
        {
            // save client in some data source
        }

        public void SaveInFile()
        {
        }

        public void SendNotificationEmail(Message message)
        {
            // send e-mail to the employee
        }

        public void SendThankYouEmail(Message message)
        {
            // send e-mail to the employee
        }

        public void SendYouAreFiredEmail(Message message)
        {
            // send e-mail to the employee
        }

        public void SendNotificationSms(Message message)
        {
        }

        public void SendThankYouSms(Message message)
        {
        }

        public void SendYouAreFiredSms(Message message)
        {
        }
    }
}