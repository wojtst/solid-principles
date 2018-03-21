using System;

namespace SolidPrinciples.Srp.Employee.Good
{
    public interface IEmployeeRepository
    {
        Employee GetById(Guid id);
        void Save(Employee employee);
    }
}