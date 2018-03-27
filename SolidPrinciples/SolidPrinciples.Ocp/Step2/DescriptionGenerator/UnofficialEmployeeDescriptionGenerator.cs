using System;

namespace SolidPrinciples.Ocp.Step2.DescriptionGenerator
{
    public class UnofficialEmployeeDescriptionGenerator : IEmployeeDescriptionGenerator
    {
        public DescriptionType DescriptionType => DescriptionType.Unofficial;

        public string GetEmployeeDescription(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}