using System;

namespace SolidPrinciples.Ocp.Step2.PaymentCalculator
{
    public class RegularEmployeePaymentCalculator : IEmployeePaymentCalculator
    {
        public decimal CalculatePayment(Step1.Employee employee)
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