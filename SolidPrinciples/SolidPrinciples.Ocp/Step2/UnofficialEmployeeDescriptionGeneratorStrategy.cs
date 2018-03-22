using System;

namespace SolidPrinciples.Ocp.Step2
{
    public class UnofficialEmployeeDescriptionGeneratorStrategy : IEmployeeDescriptionGeneratorStrategy
    {
        public DescriptionType DescriptionType => DescriptionType.Unofficial;

        public string GetEmployeeDescription(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}