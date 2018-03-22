using System;

namespace SolidPrinciples.Srp.Step4
{
    public class EmployeePaymentCalculator
    {
        public decimal CalculatePayment(Employee employee)
        {
            var employmentTime = DateTime.Now - employee.EmploymentDay;

            if (employmentTime.TotalDays > 180)
            {
                return employee.Salary * 2;
            }

            return employee.Salary;
        }
    }
}