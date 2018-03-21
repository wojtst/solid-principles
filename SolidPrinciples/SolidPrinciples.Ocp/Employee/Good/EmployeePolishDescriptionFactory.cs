using System;

namespace SolidPrinciples.Ocp.Employee.Good
{
    public class EmployeePolishDescriptionFactory : IEmployeeDescriptionFactory
    {
        public string CreateEmployeeDescription(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}