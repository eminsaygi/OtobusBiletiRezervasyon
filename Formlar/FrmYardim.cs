using System;
using System.Windows.Forms;

namespace OtobüsBiletRezarvasyon.Formlar
{
    public partial class FrmYardim : DevExpress.XtraEditors.XtraForm
    {
        public FrmYardim()
        {
            InitializeComponent();
        }

       
        

        private void pictureEdit4_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void pictureEdit5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit5_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void pictureEdit4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/eminsaygı/");
        }
    }
}