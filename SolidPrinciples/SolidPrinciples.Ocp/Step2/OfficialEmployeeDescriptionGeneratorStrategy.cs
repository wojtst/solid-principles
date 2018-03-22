using System;

namespace SolidPrinciples.Ocp.Step2
{
    public class OfficialEmployeeDescriptionGeneratorStrategy : IEmployeeDescriptionGeneratorStrategy
    {
        public DescriptionType DescriptionType => DescriptionType.Official;

        public string GetEmployeeDescription(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}