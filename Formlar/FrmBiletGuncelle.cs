using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtobüsBiletRezarvasyon.Formlar
{
    public partial class FrmBiletGuncelle : Form
    {
        public FrmBiletGuncelle()
        {
            InitializeComponent();
        }

        Db baglan = new Db();
        public string tc, Ad, Soyad, Telefon, BiletNo, Guzergah, SeferTarihi, SeferSaati, ID, KoltukNo, Cinsiyet;

        private void timeSeferSaat_TextChanged(object sender, EventArgs e)
        {
            SeferSaati = timeSeferSaat.Text;
        }

        private void txtBiletNo_TextChanged(object sender, EventArgs e)
        {
            BiletNo = txtBiletNo.Text;
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
            Telefon = txtTelefonNo.Text;
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            Soyad = txtSoyad.Text;
        }

        private void cmbCinsiyet_TextChanged(object sender, EventArgs e)
        {
            Cinsiyet = cmbCinsiyet.Text;
        }

        private void txtKoltukNo_TextChanged(object sender, EventArgs e)
        {
            KoltukNo = txtKoltukNo.Text;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            ID = txtID.Text;
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            Ad = txtAd.Text;
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            tc = txtTC.Text;
        }

        private void FrmBiletBilgisi_Load(object sender, EventArgs e)
        {
            Liste();
        }

        public void Liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblBilet", baglan.Baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Baglanti();

            SqlCommand komut = new SqlCommand("Update tblBilet set TC=@p1,Ad=@p2,Soyad=@p3,Telefon=@p4,Guzergah=@p5,SeferTarihi=@p7,BiletNo=@p8,KoltukNo=@p9,Cinsiyet=@p10 where ID=@p11", baglan.Baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            komut.Parameters.AddWithValue("@p2", Ad);
            komut.Parameters.AddWithValue("@p3", Soyad);
            komut.Parameters.AddWithValue("@p4", Telefon);
            komut.Parameters.AddWithValue("@p5", Guzergah);
            //komut.Parameters.AddWithValue("@p6", SeferSaati);
            komut.Parameters.AddWithValue("@p7", dateSeferTarih.Text);
            komut.Parameters.AddWithValue("@p8", BiletNo);
            komut.Parameters.AddWithValue("@p9", KoltukNo);
            komut.Parameters.AddWithValue("@p10", Cinsiyet);
            komut.Parameters.AddWithValue("@p11", ID);
            komut.ExecuteNonQuery();
            baglan.Baglanti().Close();

            XtraMessageBox.Show("Bilet Başarılı bir şekilde güncellendi",
               "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Liste();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                txtID.Text = dr[0].ToString();
                txtTC.Text = dr[1].ToString();
                txtAd.Text = dr[2].ToString();
                txtSoyad.Text = dr[3].ToString();
                txtTelefonNo.Text = dr[4].ToString();
                cmbGuzergah.Text = dr[5].ToString();
                timeSeferSaat.Text = dr[6].ToString();
                dateSeferTarih.Text = dr[7].ToString();
                txtBiletNo.Text = dr[8].ToString();
                txtKoltukNo.Text = dr[9].ToString();
                cmbCinsiyet.Text = dr[10].ToString();
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Liste();
        }
    }
}