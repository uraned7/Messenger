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

namespace Messenger.Views
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        //Переход в сам чат
        private void RegBut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Messenger());
        }

        //Отправка пользователя обратно на окно входа в приложение
        private void AuthBut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
