using System;

namespace SolidPrinciples.Srp.Step4
{
    public class EmployeeRepository
    {
        public Employee GetById(Guid id)
        {
            // get an employee from some data source
            return new Employee();
        }

        public void Save(Employee employee)
        {
            // save employee in some data source
        }
    }
}