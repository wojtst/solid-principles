namespace SolidPrinciples.Ocp.Step1.PaymentCalculator
{
    public class ManagerPaymentCalculator : IEmployeePaymentCalculator
    {
        public decimal CalculatePayment(Employee employee)
        {
            return employee.Salary * 10;
        }
    }
}