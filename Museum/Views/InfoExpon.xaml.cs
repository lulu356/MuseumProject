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
    public partial class InfoExpon : Window
    {
        
        public InfoExpon()
        {
            InitializeComponent();
            Name_Exponat.Text = AppData.expon.Name_Exponat;
            Opisanie_Exponat.Text = AppData.expon.Description;
            Zal_Exponat.Text = AppData.expon.Zal.ToString();
        }
    }
}
