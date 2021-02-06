using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace OtobüsBiletRezarvasyon.Formlar
{
    public partial class FrmBiletEkleme : Form
    {
        public FrmBiletEkleme()
        {
            InitializeComponent();
        }

        private FrmBiletDuzenle frm = new FrmBiletDuzenle();

        Db baglan = new Db();

        public string tc, Ad, Soyad, Telefon, BiletNo, Guzergah, SeferTarihi, SeferSaati, KoltukNo, Cinsiyet;

        private void timeSeferSaat_TextChanged(object sender, EventArgs e)
        {
            SeferSaati = timeSeferSaat.Text;
        }

        private void txtBiletNo_TextChanged(object sender, EventArgs e)
        {
            BiletNo = txtBiletNo.Text;
        }

        private void cmbCinsiyet_TextChanged(object sender, EventArgs e)
        {
            Cinsiyet = cmbCinsiyet.Text;
        }

        private void FrmBiletEkleme_Load(object sender, EventArgs e)
        {
            Captcha();
        }

        private void txtKoltukNo_TextChanged(object sender, EventArgs e)
        {
            KoltukNo = txtKoltukNo.Text;
        }

        private void dateSeferTarih_TextChanged(object sender, EventArgs e)
        {
            SeferSaati = dateSeferTarih.Text;
        }

        private void cmbGuzergah_TextChanged(object sender, EventArgs e)
        {
            Guzergah = cmbGuzergah.Text;
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            Telefon = txtNo.Text;
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            Soyad = txtSoyad.Text;
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            Ad = txtAdi.Text;
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            tc = txtTC.Text;
        }

        private void btnBiletKaydet_Click(object sender, EventArgs e)
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

            XtraMessageBox.Show("Bilet Başarılı bir şekilde sisteme kaydedildi",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm.Liste();
            Captcha();
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
    }
}