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

namespace SmartRay_Leitwarte.Pages.NLA570
{
    /// <summary>
    /// Interaktionslogik für AUDI_B9_4WD_Aenderungen.xaml
    /// </summary>
    public partial class AUDI_B9_4WD_Aenderungen : Page
    {
        public AUDI_B9_4WD_Aenderungen()
        {
            InitializeComponent();
        }
        private void btn_neue_aenderungen_Click(object sender, RoutedEventArgs e)
        {
            label.Visibility = Visibility.Visible;
        }

        private void btn_quittieren_Click(object sender, RoutedEventArgs e)
        {
            label.Visibility = Visibility.Hidden;
        }
    }
}
