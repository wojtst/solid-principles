namespace SolidPrinciples.Ocp.Step2.PaymentCalculator
{
    public class TraineePaymentCalculator : IEmployeePaymentCalculator
    {
        public decimal CalculatePayment(Step1.Employee employee)
        {
            return employee.Salary / 2;
        }
    }
}