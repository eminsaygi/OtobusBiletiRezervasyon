using System;

namespace OtobüsBiletRezarvasyon.Formlar
{
    public partial class frmHaber : DevExpress.XtraEditors.XtraForm
    {
        public frmHaber()
        {
            InitializeComponent();
        }

        private void frmHaber_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberler.com");
        }
    }
}