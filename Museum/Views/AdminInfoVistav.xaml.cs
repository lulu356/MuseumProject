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
    public partial class AdminInfoVistav : Window
    {
        public AdminInfoVistav()
        {
            InitializeComponent();
            Name_Vistav.Text = AppData.Inform.Exhibition_Name;
            Opisanie_Vistav.Text = AppData.Inform.Opisanie;
            Zal_Vistav.Text = AppData.Inform.Zal.ToString();
        }
        
        private void Izmenit_Click(object sender, RoutedEventArgs e)
        {
            
            Zal zal = context.Zal.Where(i => i.ID_Zal == AppData.Inform.Zal).FirstOrDefault();
            Vistavka Informsave = context.Vistavka.Where(i => i.ID_Vistavka == AppData.Inform.ID_Vistavka).FirstOrDefault();
            Informsave.Exhibition_Name = Name_Vistav.Text;
            Informsave.Opisanie = Opisanie_Vistav.Text;
            zal.ID_Zal = Int32.Parse(Zal_Vistav.Text);
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
            Vistavka vist = context.Vistavka.Where(i => i.ID_Vistavka == AppData.Inform.ID_Vistavka).FirstOrDefault();
            context.Vistavka.Remove(vist);
            AppData.Inform = null;
            context.SaveChanges();
            MessageBox.Show("Выставка удалена!", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}
