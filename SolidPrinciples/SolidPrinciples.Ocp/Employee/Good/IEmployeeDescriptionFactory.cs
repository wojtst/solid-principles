namespace SolidPrinciples.Ocp.Employee.Good
{
    public interface IEmployeeDescriptionFactory
    {
        string CreateEmployeeDescription(Employee employee);
    }
}