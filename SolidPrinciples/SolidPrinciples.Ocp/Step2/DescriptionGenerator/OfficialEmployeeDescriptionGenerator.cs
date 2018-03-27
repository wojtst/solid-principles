using System;

namespace SolidPrinciples.Ocp.Step2.DescriptionGenerator
{
    public class OfficialEmployeeDescriptionGenerator : IEmployeeDescriptionGenerator
    {
        public DescriptionType DescriptionType => DescriptionType.Official;

        public string GetEmployeeDescription(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}