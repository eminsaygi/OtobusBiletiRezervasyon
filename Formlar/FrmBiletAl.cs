using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OtobüsBiletRezarvasyon.Formlar
{
    public partial class FrmBiletAl : Form
    {
        public FrmBiletAl()
        {
            InitializeComponent();
            btn11.Appearance.BackColor = Color.Cyan;
            btn11.Enabled = false;
            btn20.Appearance.BackColor = Color.Cyan;
            btn20.Enabled = false;
            btn9.Appearance.BackColor = Color.Cyan;
            btn9.Enabled = false;

            btn5.Appearance.BackColor = Color.Orchid;
            btn5.Enabled = false;
            btn26.Appearance.BackColor = Color.Orchid;
            btn26.Enabled = false;
            btn22.Appearance.BackColor = Color.Orchid;
            btn22.Enabled = false;

            btn30.Appearance.BackColor = Color.Orange;
            btn31.Appearance.BackColor = Color.Orange;
            btn32.Appearance.BackColor = Color.Orange;
            Captcha();
        }

        Db baglan = new Db();
        private void BiletAl()
        {
            baglan.Baglanti();

            SqlCommand komut = new SqlCommand("insert into tblBilet (TC,Ad,Soyad,Telefon,Guzergah,SeferSaati,SeferTarihi,BiletNo,KoltukNo,Cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglan.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtTC.Text);
            komut.Parameters.AddWithValue("@p2", txtAdi.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", txtNo.Text);
            komut.Parameters.AddWithValue("@p5", cmbGuzergah.Text);
            komut.Parameters.AddWithValue("@p6", timeSeferSaat.Text);
            komut.Parameters.AddWithValue("@p7", dateSeferTarih.Text);
            komut.Parameters.AddWithValue("@p8", txtBiletNo.Text);
            komut.Parameters.AddWithValue("@p9", txtKoltukNo.Text);
            komut.Parameters.AddWithValue("@p10", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            baglan.Baglanti().Close();

            XtraMessageBox.Show("Bilet Başarılı bir şekilde alınmıştır.",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        
        }
        private void Captcha()
        {
            string[] BuyukHarfler = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
            string[] KucukHarfler = { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };
            // string[] Semboller = { "+", "-", "/", "*", "!", "#", "$", "%", "½", "{", "[", "/", "(", ")", "]", "=", "}", "?", "<", ">", "|", "@", "~", "¨", "æ", "ß", ",", ";", ":", "." };

            Random rnd = new Random();

            int sembol1, sembol2, sembol3, sembol4, sembol5;

            sembol1 = rnd.Next(0, BuyukHarfler.Length);
            sembol2 = rnd.Next(0, 10);
            sembol3 = rnd.Next(0, KucukHarfler.Length);
            sembol4 = rnd.Next(0, 10);
            sembol5 = rnd.Next(0, BuyukHarfler.Length);

            txtBiletNo.Text = BuyukHarfler[sembol1] + sembol2.ToString() + KucukHarfler[sembol3] + sembol4.ToString() + BuyukHarfler[sembol5];


        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            BiletAl();

            txtAdi.Text = "";
            txtKoltukNo.Text = "";
            txtNo.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            dateSeferTarih.Text = "";
            timeSeferSaat.Text = "";
            cmbGuzergah.Text = "";
            cmbCinsiyet.Text = "";
            Captcha();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn1.Text;
            btn1.Appearance.BackColor = Color.Lime;
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn28.Text;
            btn28.Appearance.BackColor = Color.Lime;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn2.Text;
            btn2.Appearance.BackColor = Color.Lime;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn3.Text;
            btn3.Appearance.BackColor = Color.Lime;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn4.Text;
            btn4.Appearance.BackColor = Color.Lime;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn5.Text;
            btn5.Appearance.BackColor = Color.Lime;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn6.Text;
            btn6.Appearance.BackColor = Color.Lime;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn7.Text;
            btn7.Appearance.BackColor = Color.Lime;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn8.Text;
            btn8.Appearance.BackColor = Color.Lime;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn9.Text;
            btn9.Appearance.BackColor = Color.Lime;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn10.Text;
            btn10.Appearance.BackColor = Color.Lime;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn11.Text;
            btn11.Appearance.BackColor = Color.Lime;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn12.Text;
            btn12.Appearance.BackColor = Color.Lime;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn13.Text;
            btn13.Appearance.BackColor = Color.Lime;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn14.Text;
            btn14.Appearance.BackColor = Color.Lime;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn15.Text;
            btn15.Appearance.BackColor = Color.Lime;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn16.Text;
            btn16.Appearance.BackColor = Color.Lime;
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn17.Text;
            btn17.Appearance.BackColor = Color.Lime;
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn18.Text;
            btn18.Appearance.BackColor = Color.Lime;
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn19.Text;
            btn19.Appearance.BackColor = Color.Lime;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn20.Text;
            btn20.Appearance.BackColor = Color.Lime;
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn21.Text;
            btn21.Appearance.BackColor = Color.Lime;
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn22.Text;
            btn22.Appearance.BackColor = Color.Lime;
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn23.Text;
            btn23.Appearance.BackColor = Color.Lime;
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn24.Text;
            btn24.Appearance.BackColor = Color.Lime;
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn25.Text;
            btn25.Appearance.BackColor = Color.Lime;
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn26.Text;
            btn26.Appearance.BackColor = Color.Lime;
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn27.Text;
            btn27.Appearance.BackColor = Color.Lime;
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn29.Text;
            btn29.Appearance.BackColor = Color.Lime;
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn30.Text;
            btn30.Appearance.BackColor = Color.Lime;
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn31.Text;
            btn31.Appearance.BackColor = Color.Lime;
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn32.Text;
            btn32.Appearance.BackColor = Color.Lime;
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn33.Text;
            btn33.Appearance.BackColor = Color.Lime;
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn34.Text;
            btn34.Appearance.BackColor = Color.Lime;
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn35.Text;
            btn35.Appearance.BackColor = Color.Lime;
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn36.Text;
            btn36.Appearance.BackColor = Color.Lime;
        }

        private void btn37_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = btn37.Text;
            btn37.Appearance.BackColor = Color.Lime;
        }

        private void txtBiletNo_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}