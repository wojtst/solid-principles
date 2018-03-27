using System;

namespace SolidPrinciples.Ocp.Step1.PaymentCalculator
{
    public class RegularEmployeePaymentCalculator : IEmployeePaymentCalculator
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