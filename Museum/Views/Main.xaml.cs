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
using static Museum.AppData;

namespace Museum.Views
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        

        public Main()
        {
            InitializeComponent();
            Update();
            name.Text = context.Kontaks.Select(i => i.Oficial_Name).FirstOrDefault();
            Mail.Text = context.Kontaks.Select(i => i.Mail).FirstOrDefault();
            phone.Text = context.Kontaks.Select(i => i.Phone).FirstOrDefault();
            adress.Text = context.Kontaks.Select(i => i.Address).FirstOrDefault();
            
        }

        public void Update()
        {
            var datasourse = context.Expon.ToList();
            List.ItemsSource = datasourse;

            var ListVistavka = context.VistavVivod.ToList();
            vistavs.ItemsSource = ListVistavka;
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.ShowDialog();
        }

        private void List_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (vistavs.SelectedItem != null)
            {
                AppData.Inform = (VistavVivod)vistavs.SelectedItem;
                Info info = new Info();
                info.ShowDialog();

            }
        }

        private void Expon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (List.SelectedItem != null)
            {
                AppData.expon = (Expon)List.SelectedItem;
                InfoExpon info = new InfoExpon();
                info.ShowDialog();

            }
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            Vivod.Visibility = Visibility.Hidden;
            Vivod2.Visibility = Visibility.Hidden;
            plan.Visibility = Visibility.Hidden;
            TextKontaks.Visibility = Visibility.Hidden;
            TextKontaks.Visibility = Visibility.Visible;

        }

        private void events_Click(object sender, RoutedEventArgs e)
        {
            Vivod2.Visibility = Visibility.Visible;
            Vivod.Visibility = Visibility.Hidden;
            plan.Visibility = Visibility.Hidden;
            TextKontaks.Visibility = Visibility.Hidden;
        }

        private void karta_Click(object sender, RoutedEventArgs e)
        {
            plan.Visibility = Visibility.Visible;
            Vivod2.Visibility = Visibility.Hidden;
            Vivod.Visibility = Visibility.Hidden;
            TextKontaks.Visibility = Visibility.Hidden;
        }

        private void eksponats_Click(object sender, RoutedEventArgs e)
        {
            Vivod.Visibility = Visibility.Visible;
            Vivod2.Visibility = Visibility.Hidden;
            plan.Visibility = Visibility.Hidden;
            TextKontaks.Visibility = Visibility.Hidden;
        }
    }
}
