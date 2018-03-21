namespace SolidPrinciples.Srp.Employee.Good
{
    public interface IEmployeeDescriptionFactory
    {
        string CreateEmployeeDescription(Employee employee);
    }
}