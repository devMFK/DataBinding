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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string name { get; set; } = "Bayram"; 
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            Info infoWindow = new Info();
            infoWindow.Show();
            this.Close();

        }

        private void MainTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Klavyeye Bastın");
        }
    }
}
