using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtobüsBiletRezarvasyon.Formlar
{
    public partial class FrmBiletDuzenle : Form
    {
        public FrmBiletDuzenle()
        {
            InitializeComponent();
            Liste();
            
        }

        private String ID;

        private void FrmBiletDuzenle_Load(object sender, EventArgs e)
        {
        }
        Db baglan = new Db();


        public void Liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblBilet", baglan.Baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

      
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FrmBiletEkleme frmBiletEkleme = new FrmBiletEkleme();
            frmBiletEkleme.Show();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Liste();
          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Baglanti();
            SqlCommand komutSil = new SqlCommand("Delete from tblBilet where ID=@p1", baglan.Baglanti());
            komutSil.Parameters.AddWithValue("@p1", ID);
            komutSil.ExecuteNonQuery();
            baglan.Baglanti().Close();



            XtraMessageBox.Show("Bilet silme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Liste();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            ID = txtID.Text;
        }
    }
}