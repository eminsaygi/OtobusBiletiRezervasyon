using System;

namespace OtobüsBiletRezarvasyon.Formlar
{
    public partial class FrmYouTube : DevExpress.XtraEditors.XtraForm
    {
        public FrmYouTube()
        {
            InitializeComponent();
        }

        private void FrmYouTube_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com");
        }
    }
}