namespace SolidPrinciples.Ocp.Step1.PaymentCalculator
{
    public interface IEmployeePaymentCalculator
    {
        decimal CalculatePayment(Employee employee);
    }
}