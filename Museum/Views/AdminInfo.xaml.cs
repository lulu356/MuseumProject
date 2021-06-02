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
    public partial class AdminInfo : Window
    {
        public AdminInfo()
        {
            InitializeComponent();
            Name_Exponat.Text = AppData.expon.Name_Exponat;
            Opisanie_Exponat.Text = AppData.expon.Description;
            Zal_Exponat.Text = AppData.expon.Zal.ToString();
        }
        
        private void Izmenit_Click(object sender, RoutedEventArgs e)
        {
            
            Zal zal = context.Zal.Where(i => i.ID_Zal == AppData.expon.Zal).FirstOrDefault();
            Exponat exponsave = context.Exponat.Where(i => i.Exponat_ID == AppData.expon.Exponat_ID).FirstOrDefault();
            exponsave.Name_Exponat = Name_Exponat.Text;
            exponsave.Description = Opisanie_Exponat.Text;
            zal.ID_Zal = Int32.Parse(Zal_Exponat.Text);
            try
            {
                context.SaveChanges();
                MessageBox.Show("Все измененно");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Exponat expon = context.Exponat.Where(i => i.Exponat_ID == AppData.expon.Exponat_ID).FirstOrDefault();
            context.Exponat.Remove(expon);
            AppData.expon = null;
            context.SaveChanges();
            MessageBox.Show("Экспонат удален!", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

        
    }
}
