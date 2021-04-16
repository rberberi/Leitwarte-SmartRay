using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace SmartRay_Leitwarte.Pages
{
    /// <summary>
    /// Interaktionslogik für Uebersicht.xaml
    /// </summary>
    public partial class Uebersicht : Page
    {

        public Uebersicht()
        {
            InitializeComponent();
        }


        //MouseOver Options NLA480
        #region
        private void lbl_ug10_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_ug10.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_ug10.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_ug10.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_ug10_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_ug10.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_ug10.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_ug10.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }

        private void lbl_ug20_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_ug20.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_ug20.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_ug20.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_ug20_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_ug20.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_ug20.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_ug20.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }

        private void lbl_op30_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_op30.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_op30.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_op30.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_op30_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_op30.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_op30.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_op30.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }

        private void lbl_op7011_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_op7011.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_op7011.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_op7011.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_op7011_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_op7011.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_op7011.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_op7011.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }

        private void lbl_op7021_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_op7021.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_op7021.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_op7021.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_op7021_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_op7021.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_op7021.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_op7021.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }

        private void lbl_op7031_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_op7031.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_op7031.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_op7031.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_op7031_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_op7031.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_op7031.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_op7031.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }

        private void lbl_op7041_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_op7041.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_op7041.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_op7041.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_op7041_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_op7041.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_op7041.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_op7041.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }
        #endregion

        //MouseOver Options NLA570
        #region
        private void lbl_b92wd_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_b92wd.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_b92wd.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_b92wd.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_b92wd_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_b92wd.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_b92wd.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_b92wd.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }

        private void lbl_b94wd_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_b94wd.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_b94wd.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_b94wd.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_b94wd_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_b94wd.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_b94wd.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_b94wd.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }
        #endregion

        //MouseOver Options NLA590
        #region
        private void lbl_ukl10_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_ukl10.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_ukl10.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_ukl10.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_ukl10_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_ukl10.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_ukl10.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_ukl10.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }

        private void lbl_ukl40_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_ukl40.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_ukl40.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_ukl40.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_ukl40_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_ukl40.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_ukl40.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_ukl40.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }
        #endregion

        //MouseOver Options NLA592
        #region
        private void lbl_r40a_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_r40a.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_r40a.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_r40a.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_r40a_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_r40a.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_r40a.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_r40a.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }

        private void lbl_r40b_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_r40b.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_r40b.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_r40b.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_r40b_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_r40b.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_r40b.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_r40b.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }

        private void lbl_r40c_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_r40c.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_r40c.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_r40c.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_r40c_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_r40c.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_r40c.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_r40c.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }

        private void lbl_r40d_MouseEnter(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_r40d.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_fq_r40d.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
            tb_nio_r40d.BorderBrush = (Brush)bc.ConvertFrom("#FF336E3B");
        }

        private void lbl_r40d_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            tb_bt_r40d.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_fq_r40d.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
            tb_nio_r40d.BorderBrush = (Brush)bc.ConvertFrom("#00FFFFFF");
        }
        #endregion

    } // CLASS Uebersicht

} //NAMESPACE
