namespace SolidPrinciples.Ocp.Step1.DescriptionGenerator
{
    public interface IEmployeeDescriptionGeneratorStrategy
    {
        string GetEmployeeDescription(Employee employee);
    }
}