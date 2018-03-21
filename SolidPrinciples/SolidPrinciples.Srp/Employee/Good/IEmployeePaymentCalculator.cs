namespace SolidPrinciples.Srp.Employee.Good
{
    public interface IEmployeePaymentCalculator
    {
        decimal CalculatePayment(Employee employee);
    }
}