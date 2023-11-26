using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForDG
{
    public class Employees
    {
        private List<Employee> employees;

        public Employees()
        {
            employees = new List<Employee>();
        }

        public void setEmployee(string firstName,  string lastName, string Designation, decimal Salary)
        {
            Employee employee = new Employee();
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.Designation = Designation;
            employee.Salary = Salary;
            AddEmployee(employee);
        }

        private void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public List<Employee> getEmployees()
        {
            return employees;
        }
    }
}
