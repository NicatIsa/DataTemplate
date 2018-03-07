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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listboxPerson.ItemsSource = App.list;
        }
        
        private void Addbutton_Click(object sender, RoutedEventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.Owner = this;
            addPerson.Show();
        }
    }
}
