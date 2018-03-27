namespace SolidPrinciples.Ocp.Step2.DescriptionGenerator
{
    public interface IEmployeeDescriptionGenerator
    {
        DescriptionType DescriptionType { get; }
        string GetEmployeeDescription(Employee employee);
    }
}