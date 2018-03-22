using System;
using System.Text;

namespace SolidPrinciples.Ocp.Step0
{
    public class EmployeeDescriptionGenerator
    {
        public string GetOfficialEmployeeDescription(Employee employee)
        {
            string jobTitle;

            var employmentTimeInDays = (DateTime.Now - employee.EmploymentDay).TotalDays;

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

            builder.AppendLine($"{jobTitle} {employee.FirstName} {employee.LastName}");
            builder.AppendLine($"E-mail: {employee.Email}");
            builder.AppendLine($"Phone: {employee.PhoneNumber}");

            return builder.ToString().Trim();
        }

        public string GetUnofficialEmployeeDescription(Employee employee)
        {
            throw new NotImplementedException();
        }

        public string GetInternalEmployeeDescription(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}