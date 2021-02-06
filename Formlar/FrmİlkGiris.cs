using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtobüsBiletRezarvasyon.Formlar
{
    public partial class FrmİlkGiris : DevExpress.XtraEditors.XtraForm
    {
        public FrmİlkGiris()
        {
            InitializeComponent();
        }
      
        Db db = new Db();
        private void pictureEdit4_Click(object sender, EventArgs e)
        {
          
            SqlCommand komut = new SqlCommand("Select * from tblADMIN where KullaniciAd=@p1 and Sifre=@p2", db.Baglanti());
            komut.Parameters.AddWithValue("@p1", textEdit1.Text);
            komut.Parameters.AddWithValue("@p2", textEdit2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                AnaSayfaForm anaSayfaForm = new AnaSayfaForm();
                
                anaSayfaForm.Show();
                
                this.Hide();

            }
            else
            {
                XtraMessageBox.Show("Hatalı bir kullanıcı adı veya parola girdiniz",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db.Baglanti().Close();
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            textEdit1.Text = "";
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            textEdit2.Text = "";
        }

        private void pictureEdit4_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {
            AnaSayfaForm anaSayfaForm = new AnaSayfaForm();
            anaSayfaForm.Show();
            this.Hide();
            XtraMessageBox.Show("Şimdilik şifresiz girmene izin verdim. Birdahakine kullanıcı adı ve şifre ile giriş yapınız.",
               "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}