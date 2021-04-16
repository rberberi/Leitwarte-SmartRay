using System.Windows;
using System.Windows.Media;

namespace SmartRay_Leitwarte
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frame_main.Content = new Pages.Uebersicht();
            tab_main.Header = "Übersicht";
            tab_aenderungen.IsEnabled = false;
            tab_nioBilder.IsEnabled = false;
        }

        #region Click-Ereignise Anlagen
        private void btn_uebersicht_Click(object sender, RoutedEventArgs e)
        {
            frame_main.Content = new Pages.Uebersicht();
            tab_main.Header = "Übersicht";
            tab_aenderungen.IsEnabled = false;
            tab_nioBilder.IsEnabled = false;
            tab_main.IsSelected = true;
        }

        private void btn_nla480_Click(object sender, RoutedEventArgs e)
        {
            this.nla480.Visibility = this.nla480.Visibility == Visibility.Visible
                            ? Visibility.Collapsed
                            : Visibility.Visible;
        }

        private void btn_nla570_Click(object sender, RoutedEventArgs e)
        {
            this.nla570.Visibility = this.nla570.Visibility == Visibility.Visible
                            ? Visibility.Collapsed
                            : Visibility.Visible;
        }

        private void btn_nla590_Click(object sender, RoutedEventArgs e)
        {
            this.nla590.Visibility = this.nla590.Visibility == Visibility.Visible
                            ? Visibility.Collapsed
                            : Visibility.Visible;
        }

        private void btn_nla592_Click(object sender, RoutedEventArgs e)
        {
            this.nla592.Visibility = this.nla592.Visibility == Visibility.Visible
                            ? Visibility.Collapsed
                            : Visibility.Visible;
        }
        #endregion

        #region Click-Ereignise Systeme

        //NLA480
        private void btn_op30_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "OP 30";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA480.OP30();
            tab_main.IsSelected = true;
        }

        private void btn_op7011_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "OP 70/11";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA480.OP70_11();
            tab_main.IsSelected = true;
        }

        private void btn_op7021_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "OP 70/21";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA480.OP70_21();
            tab_main.IsSelected = true;
        }


        private void btn_op7031_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "OP 70/31";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA480.OP70_31();
            tab_main.IsSelected = true;
        }

        private void btn_op7041_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "OP 70/41";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA480.OP70_41();
            tab_main.IsSelected = true;
        }

        private void btn_ug10_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "UG 10";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA480.UG10();
            tab_main.IsSelected = true;
        }

        private void btn_ug20_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "UG 20";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA480.UG20();
            tab_main.IsSelected = true;
        }

        //NLA 570
        private void btn_audi2wd_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "Audi B9 2WD";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA570.AUDI_B9_2WD();
            tab_main.IsSelected = true;
        }

        private void btn_audi4wd_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "Audi B9 4WD";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA570.AUDI_B9_4WD();
            tab_main.IsSelected = true;
        }

        //NLA590
        private void btn_ukl_op10_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "UKL VAT OP10";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA590.UKL_VAT_OP10();
            tab_main.IsSelected = true;
        }

        private void btn_ukl_op40_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "UKL VAT OP40";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA590.UKL_VAT_OP40();
            tab_main.IsSelected = true;
        }

        //NLA592
        private void btn_r40a_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "OP R40 A";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA592.OP_R40_A();
            tab_main.IsSelected = true;
        }

        private void btn_r40b_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "OP R40 B";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA592.OP_R40_B();
            tab_main.IsSelected = true;
        }

        private void btn_r40c_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "OP R40 C";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA592.OP_R40_C();
            tab_main.IsSelected = true;
        }

        private void btn_r40d_Click(object sender, RoutedEventArgs e)
        {
            tab_main.Header = "OP R40 D";
            tab_aenderungen.IsEnabled = true;
            tab_nioBilder.IsEnabled = true;
            frame_main.Content = new Pages.NLA592.OP_R40_D();
            tab_main.IsSelected = true;
        }


        #endregion

        #region Ereignise Tab-Selection changed

        private void tab_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            #region Änderung Tab Selected
            if (tab_aenderungen.IsSelected)
            {
                #region NLA489
                if (tab_main.Header.ToString() == "OP 30")
                {
                    frame_aenderungen.Content = new Pages.NLA480.OP30_Aenderungen();
                }
                if (tab_main.Header.ToString() == "OP 70/11")
                {
                    frame_aenderungen.Content = new Pages.NLA480.OP70_11_Aenderungen();
                }
                if (tab_main.Header.ToString() == "OP 70/21")
                {
                    frame_aenderungen.Content = new Pages.NLA480.OP70_21_Aenderungen();
                }
                if (tab_main.Header.ToString() == "OP 70/31")
                {
                    frame_aenderungen.Content = new Pages.NLA480.OP70_31_Aenderungen();
                }
                if (tab_main.Header.ToString() == "OP 70/41")
                {
                    frame_aenderungen.Content = new Pages.NLA480.OP70_41_Aenderungen();
                }
                if (tab_main.Header.ToString() == "UG 10")
                {
                    frame_aenderungen.Content = new Pages.NLA480.UG10_Aenderungen();
                }
                if (tab_main.Header.ToString() == "UG 20")
                {
                    frame_aenderungen.Content = new Pages.NLA480.UG20_Aenderungen();
                }
                #endregion

                #region NLA570
                if (tab_main.Header.ToString() == "Audi B9 2WD")
                {
                    frame_aenderungen.Content = new Pages.NLA570.AUDI_B9_2WD_Aenderungen();
                }
                if (tab_main.Header.ToString() == "Audi B9 4WD")
                {
                    frame_aenderungen.Content = new Pages.NLA570.AUDI_B9_4WD_Aenderungen();
                }
                #endregion

                #region NLA590
                if (tab_main.Header.ToString() == "UKL VAT OP10")
                {
                    frame_aenderungen.Content = new Pages.NLA590.UKL_VAT_OP10_Aenderungen();
                }
                if (tab_main.Header.ToString() == "UKL VAT OP40")
                {
                    frame_aenderungen.Content = new Pages.NLA590.UKL_VAT_OP40_Aenderungen();
                }
                #endregion

                #region NLA592
                if (tab_main.Header.ToString() == "OP R40 A")
                {
                    frame_aenderungen.Content = new Pages.NLA592.OP_R40_A_Aenderungen();
                }
                if (tab_main.Header.ToString() == "OP R40 B")
                {
                    frame_aenderungen.Content = new Pages.NLA592.OP_R40_B_Aenderungen();
                }
                if (tab_main.Header.ToString() == "OP R40 C")
                {
                    frame_aenderungen.Content = new Pages.NLA592.OP_R40_C_Aenderungen();
                }
                if (tab_main.Header.ToString() == "OP R40 D")
                {
                    frame_aenderungen.Content = new Pages.NLA592.OP_R40_D_Aenderungen();
                }
                #endregion

            }//Tab-Änderung selected
            #endregion

            #region n.i.O Bilder Tab Selected
            if (tab_nioBilder.IsSelected)
            {
                #region NLA489
                if (tab_main.Header.ToString() == "OP 30")
                {
                    frame_nioBilder.Content = new Pages.NLA480.OP30_Bilder();
                }
                if (tab_main.Header.ToString() == "OP 70/11")
                {
                    frame_nioBilder.Content = new Pages.NLA480.OP70_11_Bilder();
                }
                if (tab_main.Header.ToString() == "OP 70/21")
                {
                    frame_nioBilder.Content = new Pages.NLA480.OP70_21_Bilder();
                }
                if (tab_main.Header.ToString() == "OP 70/31")
                {
                    frame_nioBilder.Content = new Pages.NLA480.OP70_31_Bilder();
                }
                if (tab_main.Header.ToString() == "OP 70/41")
                {
                    frame_nioBilder.Content = new Pages.NLA480.OP70_41_Bilder();
                }
                if (tab_main.Header.ToString() == "UG 10")
                {
                    frame_nioBilder.Content = new Pages.NLA480.UG10_Bilder();
                }
                if (tab_main.Header.ToString() == "UG 20")
                {
                    frame_nioBilder.Content = new Pages.NLA480.UG20_Bilder();
                }
                #endregion

                #region NLA570
                if (tab_main.Header.ToString() == "Audi B9 2WD")
                {
                    frame_nioBilder.Content = new Pages.NLA570.AUDI_B9_2WD_Bilder();
                }
                if (tab_main.Header.ToString() == "Audi B9 4WD")
                {
                    frame_nioBilder.Content = new Pages.NLA570.AUDI_B9_4WD_Bilder();
                }
                #endregion

                #region NLA590
                if (tab_main.Header.ToString() == "UKL VAT OP10")
                {
                    frame_nioBilder.Content = new Pages.NLA590.UKL_VAT_OP10_Bilder();
                }
                if (tab_main.Header.ToString() == "UKL VAT OP40")
                {
                    frame_nioBilder.Content = new Pages.NLA590.UKL_VAT_OP40_Bilder();
                }
                #endregion

                #region NLA592
                if (tab_main.Header.ToString() == "OP R40 A")
                {
                    frame_nioBilder.Content = new Pages.NLA592.OP_R40_A_Bilder();
                }
                if (tab_main.Header.ToString() == "OP R40 B")
                {
                    frame_nioBilder.Content = new Pages.NLA592.OP_R40_B_Bilder();
                }
                if (tab_main.Header.ToString() == "OP R40 C")
                {
                    frame_nioBilder.Content = new Pages.NLA592.OP_R40_C_Bilder();
                }
                if (tab_main.Header.ToString() == "OP R40 D")
                {
                    frame_nioBilder.Content = new Pages.NLA592.OP_R40_D_Bilder();
                }
                #endregion

            }//Tab-Änderung selected
            #endregion

        }//Tab-Selection changed
        #endregion

    }//CLASS
}//NAMESPACE
