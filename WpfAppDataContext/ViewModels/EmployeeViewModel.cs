using ClassLibraryForDG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDataContext.ViewModels
{
    public class EmployeeViewModel
    {
        private Employees _employees;
        private List<Employee> _addNewEmployees;

        public EmployeeViewModel()
        {
            _employees = new Employees();
            _employees.setEmployee("Ayanfe", "Olabamiji", "Doctor", 5000000);
            _employees.setEmployee("Jaynell", "Olabamiji", "Engineer", 5000000);
        }

        public List<Employee> Employees{
            get
            {
                return _employees.getEmployees();
            }

            }

    }

}
