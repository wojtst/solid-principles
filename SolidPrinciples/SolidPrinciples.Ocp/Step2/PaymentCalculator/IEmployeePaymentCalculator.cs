namespace SolidPrinciples.Ocp.Step2.PaymentCalculator
{
    public interface IEmployeePaymentCalculator
    {
        decimal CalculatePayment(Step1.Employee employee);
    }
}