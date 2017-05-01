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
using myelements;

namespace WpfApp1
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
        

        private void sendClick(object sender, RoutedEventArgs e)
        {

            //int a = 5;
            int a = int.Parse(txtUserName.Text);
            int c = a + 5;
            txtSomeText.Text = c.ToString();
            //MessageBox.Show("Salam");
        }

        private void txtSomeText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
