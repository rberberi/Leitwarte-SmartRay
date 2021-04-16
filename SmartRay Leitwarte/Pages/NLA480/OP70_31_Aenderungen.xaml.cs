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

namespace SmartRay_Leitwarte.Pages.NLA480
{
    /// <summary>
    /// Interaktionslogik für OP70_31_Aenderungen.xaml
    /// </summary>
    public partial class OP70_31_Aenderungen : Page
    {
        public OP70_31_Aenderungen()
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
