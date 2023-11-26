using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppDataContext.ViewModels;

namespace WpfAppDataContext.UI
{
    /// <summary>
    /// Interaction logic for Datagrid.xaml
    /// </summary>
    public partial class Datagrid : Window
    {
        public Datagrid()
        {
            InitializeComponent();
           // EmployeeViewModel employeeViewModel = new EmployeeViewModel();
           // this.DataContext = employeeViewModel;
           // dgvEmployee.ItemsSource = employeeViewModel.VmEmployees();
        }

        private void AddRows(object sender, DataGridRowEditEndingEventArgs e)
        {
            ClassLibraryForDG.Employee employee = e.Row.Item as ClassLibraryForDG.Employee;
            if (employee != null && e.EditAction == DataGridEditAction.Commit && e.Row.IsNewItem)
            {
                EmployeeViewModel employeeViewModel = (EmployeeViewModel) DataContext;
                employeeViewModel.Employees.Add(employee);
            }
        }
    }
}
