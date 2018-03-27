using System;

namespace SolidPrinciples.Ocp.Step0
{
    public class EmployeePaymentCalculator
    {
        public decimal CalculatePaymentForRegularEmployee(Employee employee)
        {
            var employmentTime = DateTime.Now - employee.EmploymentDay;

            if (employmentTime.TotalDays > 180)
            {
                return employee.Salary * 2;
            }

            return employee.Salary;
        }

        public decimal CalculatePaymentForManager(Employee employee)
        {
            return employee.Salary * 10;
        }

        public decimal CalculatePaymentForTrainee(Employee employee)
        {
            return employee.Salary / 2;
        }
    }
}
