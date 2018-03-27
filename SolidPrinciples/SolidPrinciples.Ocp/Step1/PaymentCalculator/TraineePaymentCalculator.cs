namespace SolidPrinciples.Ocp.Step1.PaymentCalculator
{
    public class TraineePaymentCalculator : IEmployeePaymentCalculator
    {
        public decimal CalculatePayment(Employee employee)
        {
            return employee.Salary / 2;
        }
    }
}