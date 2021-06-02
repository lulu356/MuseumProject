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
    public partial class AddVistavka : Window
    {
        public AddVistavka()
        {
            InitializeComponent();
            
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                context.Vistavka.Add(new Vistavka
                {
                    Exhibition_Name = Name_Vistavki.Text,
                    Opisanie = Opisanie_Vistavki.Text,
                    ID_Zal = Int32.Parse(Zal_Vistavki.Text),
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
