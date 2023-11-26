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

namespace WpfAppDataContext.UI
{
    /// <summary>
    /// Interaction logic for DCViaCodeBehind.xaml
    /// </summary>
    public partial class DCViaCodeBehind : Window
    {
        public DCViaCodeBehind()
        {
            InitializeComponent();
            Binding binding = new Binding("Text");
            binding.Source = txtName;  
            lblValue.SetBinding(TextBlock.TextProperty, binding);
        }
    }
}
