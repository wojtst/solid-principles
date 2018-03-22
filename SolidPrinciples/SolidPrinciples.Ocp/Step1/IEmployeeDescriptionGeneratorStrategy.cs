namespace SolidPrinciples.Ocp.Step1
{
    public interface IEmployeeDescriptionGeneratorStrategy
    {
        string GetEmployeeDescription(Employee employee);
    }
}