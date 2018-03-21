using System;

namespace SolidPrinciples.Ocp.Employee.Good
{
    public class EmployeeEnglishDescriptionFactory : IEmployeeDescriptionFactory
    {
        public string CreateEmployeeDescription(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}