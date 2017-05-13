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

namespace SampleForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("FullName: ").Append(fullName.Text);
            sb.Append(" Sex? ").Append(male.IsChecked.Value ? "Male" : "Female" );
            sb.Append(" Computer: ");
            sb.Append(desktop.IsChecked.Value ? "Desktop" : "");
            sb.Append(laptop.IsChecked.Value ? "Laptop" : "");
            sb.Append(tablet.IsChecked.Value ? "Tablet" : "");
            sb.Append(" Your job ");
            sb.Append((job.SelectedItem as ComboBoxItem).Content);
            sb.Append(" Delivery Date ");
            sb.Append(deliveryDate.SelectedDate.ToString());
            MessageBox.Show(sb.ToString());
        }
    }
}
