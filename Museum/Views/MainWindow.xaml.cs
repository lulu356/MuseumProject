using Museum;
using Museum.Views;
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
using static Museum.AppData;
namespace Museum
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Введите пароль";
                password.Foreground = Brushes.Gray;
            }
                
        }

        private void password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (password.Text == "Введите пароль" )
            {
                password.Text = "";
                password.Foreground = Brushes.Black;
            }
        }

        private void login_GotFocus(object sender, RoutedEventArgs e)
        {
            if (login.Text == "Введите логин")
            {
                login.Text = "";
                login.Foreground = Brushes.Black;
            }
        }

        private void login_LostFocus(object sender, RoutedEventArgs e)
        {
            if (login.Text == "")
            {
                login.Text = "Введите логин";
                login.Foreground = Brushes.Gray;
            }
        }

        private void buttlogin_Click(object sender, RoutedEventArgs e)
        {
            User u = context.User.Where(i => i.Login == login.Text).FirstOrDefault();

            if (u != null)
            {
                if (u.Password == password.Text)
                {
                    Admin user = new Admin();
                    this.Close();
                    user.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }

            }
            else
            {
                MessageBox.Show("Пользователя не существует");
            }
            
        }
    }
}
