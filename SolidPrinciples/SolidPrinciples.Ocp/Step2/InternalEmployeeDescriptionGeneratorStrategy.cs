using System;

namespace SolidPrinciples.Ocp.Step2
{
    public class InternalEmployeeDescriptionGeneratorStrategy : IEmployeeDescriptionGeneratorStrategy
    {
        public DescriptionType DescriptionType => DescriptionType.Internal;

        public string GetEmployeeDescription(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}