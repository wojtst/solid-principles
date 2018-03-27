using System;

namespace SolidPrinciples.Ocp.Step2.PaymentCalculator
{
    public class EmployeePaymentCalculatorFactory
    {
        public IEmployeePaymentCalculator Create(EmployeeType employeeType)
        {
            switch (employeeType)
            {
                case EmployeeType.Trainee:
                    return new TraineePaymentCalculator();
                case EmployeeType.Regular:
                    return new RegularEmployeePaymentCalculator();
                case EmployeeType.Manager:
                    return new ManagerPaymentCalculator();
                default:
                    throw new ArgumentOutOfRangeException(nameof(employeeType), employeeType, null);
            }
        }
    }
}