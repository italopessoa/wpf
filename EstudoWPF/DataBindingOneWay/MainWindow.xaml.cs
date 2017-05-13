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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBindingOneWay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Employee emp;
        public MainWindow()
        {
            InitializeComponent();
            this.emp = new Employee
            {
                Name = "Joe",
                Title = "QA",
                StartDate = DateTime.Now
            };
            DataContext = this.emp;
        }

        private void ButtonChange_Click(object sender, RoutedEventArgs e)
        {
            this.emp.Name = "Italo";
            this.emp.Title = "Developer";
        }
    }
}
