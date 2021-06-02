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
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class AddExponat : Window
    {
        public AddExponat()
        {
            InitializeComponent();
            
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                context.Exponat.Add(new Exponat
                {
                    Name_Exponat = Name_Exponat.Text,
                    Description = Opisanie_Exponat.Text,
                    ID_zal = Int32.Parse(Zal_Exponat.Text),
                }); ;
                MessageBox.Show("Успех");
                context.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
