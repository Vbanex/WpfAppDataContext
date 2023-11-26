using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using ClassLibraryForDG;

namespace WpfAppDataContext.UI
{
    /// <summary>
    /// Interaction logic for UserChanges.xaml
    /// </summary>
    public partial class UserChanges : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();
        public UserChanges()
        {
            InitializeComponent();
            users.Add(new User() { Name = "Segun" });
            users.Add(new User() { Name = "Paul" });
            users.Add(new User() { Name = "Banji" });
            lblUsers.ItemsSource = users;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            var name = txtName.Text;
            users.Add(new User() { Name = name });
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            var name = txtName.Text;
            if (lblUsers.SelectedItem != null)
            {
                ((User)lblUsers.SelectedItem).Name = name;
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(lblUsers.SelectedItem != null)
            {
                users.Remove(lblUsers.SelectedItem as User);
            }
        }
    }
}
