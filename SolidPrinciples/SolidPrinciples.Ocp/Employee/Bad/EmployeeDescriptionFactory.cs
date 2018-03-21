using System;

namespace SolidPrinciples.Ocp.Employee.Bad
{
    public class EmployeeDescriptionFactory
    {
        public string CreateEmployeeDescription(Employee employee)
        {
            // ...
            throw new NotImplementedException();
        }
    }
}