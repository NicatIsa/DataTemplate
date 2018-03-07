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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for AddPerson.xaml
    /// </summary>
    public partial class AddPerson : Window
    {
        Person person;
        public AddPerson()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person = new Person
            {
                Name = textboxName.Text,
                Surname = textboxSurname.Text,
                ImagePath = textboxImagePath.Text
            };

            App.list.Add(person);
            Hide();

        }
    }
}
