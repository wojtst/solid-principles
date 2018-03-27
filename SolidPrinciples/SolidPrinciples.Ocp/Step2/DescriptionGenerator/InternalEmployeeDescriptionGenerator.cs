using System;

namespace SolidPrinciples.Ocp.Step2.DescriptionGenerator
{
    public class InternalEmployeeDescriptionGenerator : IEmployeeDescriptionGenerator
    {
        public DescriptionType DescriptionType => DescriptionType.Internal;

        public string GetEmployeeDescription(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}