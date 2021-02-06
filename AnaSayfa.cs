using DevExpress.XtraBars;
using OtobüsBiletRezarvasyon.Formlar;
using System;
using System.Threading;
using System.Windows.Forms;

namespace OtobüsBiletRezarvasyon
{
    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
            Thread.Sleep(1000);
        }

        private Formlar.FrmBiletAl frmBiletAl;
        private Formlar.FrmBiletDuzenle frmBiletDuzenle;
        private Formlar.FrmBiletGuncelle frmBiletGuncelle;
       // private Formlar.FrmRapor frmRapor;
        private Formlar.FrmRaporOku frmRaporOku;
        private Formlar.FrmDashBoardServisi frmDashBoardServisi;
        private Formlar.FrmWord frmWord;
        private Formlar.FrmMap frmMap;
        private Formlar.FrmOzCekim frmOzCekim;
        private Formlar.FrmAnaSayfa frmAnaSayfa;
        private Formlar.FrmYouTube frmYouTube;
        private Formlar.frmHaber frmHaber;
        private Formlar.FrmYardim frmYardim;

        private void BtnBiletAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmBiletAl == null || frmBiletAl.IsDisposed)
            {
                frmBiletAl = new FrmBiletAl();
                frmBiletAl.MdiParent = this;
                frmBiletAl.Show();
            }
        }

        private void BtnBiletDuzenle_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmBiletDuzenle == null || frmBiletDuzenle.IsDisposed)
            {
                frmBiletDuzenle = new FrmBiletDuzenle();
                frmBiletDuzenle.MdiParent = this;
                frmBiletDuzenle.Show();
            }
        }

        private void BtnBiletBilgisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmBiletGuncelle == null || frmBiletGuncelle.IsDisposed)
            {
                frmBiletGuncelle = new FrmBiletGuncelle();
                frmBiletGuncelle.MdiParent = this;
                frmBiletGuncelle.Show();
            }
        }

        private void BtnRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmDashBoardServisi == null || frmDashBoardServisi.IsDisposed)
            {
                frmDashBoardServisi = new FrmDashBoardServisi();
                frmDashBoardServisi.MdiParent = this;
                frmDashBoardServisi.Show();
            }
        }

        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {
            {
                if (frmAnaSayfa == null || frmRaporOku.IsDisposed)
                {
                    frmAnaSayfa = new FrmAnaSayfa();
                    frmAnaSayfa.MdiParent = this;
                    frmAnaSayfa.Show();
                }
            }
        }

        private void btnRaporOku_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmRaporOku == null || frmRaporOku.IsDisposed)
            {
                frmRaporOku = new FrmRaporOku();
                frmRaporOku.MdiParent = this;
                frmRaporOku.Show();
            }
        }

        private void btnGostergePaneli_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmDashBoardServisi == null || frmDashBoardServisi.IsDisposed)
            {
                frmDashBoardServisi = new FrmDashBoardServisi();
                frmDashBoardServisi.MdiParent = this;
                frmDashBoardServisi.Show();
            }
        }

        private void btnOffice_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmWord == null || frmWord.IsDisposed)
            {
                frmWord = new FrmWord();
                frmWord.MdiParent = this;
                frmWord.Show();
            }
        }

        private void BtnHarita_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmMap == null || frmMap.IsDisposed)
            {
                frmMap = new FrmMap();
                frmMap.MdiParent = this;
                frmMap.Show();
            }
        }

        private void btnOzCekim_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmOzCekim == null || frmOzCekim.IsDisposed)
            {
                frmOzCekim = new FrmOzCekim();
                frmOzCekim.MdiParent = this;
                frmOzCekim.Show();
            }
        }

        private void BtnAnaSayfa_ItemClick(object sender, ItemClickEventArgs e)
        {
            {
                if (frmAnaSayfa == null || frmAnaSayfa.IsDisposed)
                {
                    frmAnaSayfa = new FrmAnaSayfa();
                    frmAnaSayfa.MdiParent = this;
                    frmAnaSayfa.Show();
                }
            }
        }

        private void BtnYouTube_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmYouTube == null || frmYouTube.IsDisposed)
            {
                frmYouTube = new FrmYouTube();
                frmYouTube.MdiParent = this;
                frmYouTube.Show();
            }
        }

        private void BtnHaber_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmHaber == null || frmHaber.IsDisposed)
            {
                frmHaber = new frmHaber();
                frmHaber.MdiParent = this;
                frmHaber.Show();
            }
        }

        private void BtnYardim_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmYardim == null || frmYardim.IsDisposed)
            {
                frmYardim = new FrmYardim();
                frmYardim.Show();
            }
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}