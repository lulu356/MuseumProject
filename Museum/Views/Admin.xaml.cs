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
    public partial class Admin : Window
    {
        public List<Expon> datasourse = new List<Expon>();
        public List<VistavVivod> datasourse2 = new List<VistavVivod>();
        public Admin()
        {
            InitializeComponent();
            Update();

        }

        public void Update()
        {
            datasourse.AddRange(context.Expon.ToList());
            List.ItemsSource = datasourse;

            datasourse2.AddRange(context.VistavVivod.ToList());
            vistavs.ItemsSource = datasourse2;
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.ShowDialog();
        }

        private void vistavs_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (vistavs.SelectedItem != null)
            {
                AppData.Inform = (VistavVivod)vistavs.SelectedItem;
                AdminInfoVistav info = new AdminInfoVistav();
                info.ShowDialog();
                datasourse2.Clear();
                datasourse2.AddRange(context.VistavVivod.ToList());
                vistavs.Items.Refresh();

            }
        }

        private void Expon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (List.SelectedItem != null)
            {
                AppData.expon = (Expon)List.SelectedItem;
                AdminInfo info = new AdminInfo();
                info.ShowDialog();
                datasourse.Clear();
                datasourse.AddRange(context.Expon.ToList());
                List.Items.Refresh();
            }
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            add2.Visibility = Visibility.Hidden;
            add.Visibility = Visibility.Hidden;
            Vivod.Visibility = Visibility.Hidden;
            Vivod2.Visibility = Visibility.Hidden;
            plan.Visibility = Visibility.Hidden;
            TextKontaks.Visibility = Visibility.Hidden;
            TextKontaks.Visibility = Visibility.Visible;
        }

        private void events_Click(object sender, RoutedEventArgs e)
        {
            add.Visibility = Visibility.Hidden;
            Vivod2.Visibility = Visibility.Visible;
            add2.Visibility = Visibility.Visible;
            Vivod.Visibility = Visibility.Hidden;
            plan.Visibility = Visibility.Hidden;
            TextKontaks.Visibility = Visibility.Hidden;
        }

        private void karta_Click(object sender, RoutedEventArgs e)
        {
            add.Visibility = Visibility.Hidden;
            add2.Visibility = Visibility.Hidden;
            plan.Visibility = Visibility.Visible;
            Vivod2.Visibility = Visibility.Hidden;
            Vivod.Visibility = Visibility.Hidden;
            TextKontaks.Visibility = Visibility.Hidden;
        }

        private void eksponats_Click(object sender, RoutedEventArgs e)
        {
            Vivod.Visibility = Visibility.Visible;
            add.Visibility = Visibility.Visible;
            add2.Visibility = Visibility.Hidden;
            Vivod2.Visibility = Visibility.Hidden;
            plan.Visibility = Visibility.Hidden;
            TextKontaks.Visibility = Visibility.Hidden;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            AddExponat info = new AddExponat();
            info.ShowDialog();
        }

        private void add2_Click(object sender, RoutedEventArgs e)
        {
            AddVistavka info = new AddVistavka();
            info.ShowDialog();
        }
    }
}

