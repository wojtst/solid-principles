using System;

namespace SolidPrinciples.Ocp.Step1.DescriptionGenerator
{
    public class InternalEmployeeDescriptionGeneratorStrategy : IEmployeeDescriptionGeneratorStrategy
    {
        public string GetEmployeeDescription(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}