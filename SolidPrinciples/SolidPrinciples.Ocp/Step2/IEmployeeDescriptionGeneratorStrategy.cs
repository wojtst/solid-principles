namespace SolidPrinciples.Ocp.Step2
{
    public interface IEmployeeDescriptionGeneratorStrategy
    {
        DescriptionType DescriptionType { get; }
        string GetEmployeeDescription(Employee employee);
    }
}