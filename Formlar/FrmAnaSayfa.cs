using System;
using System.Drawing;
namespace OtobüsBiletRezarvasyon.Formlar
{
    public partial class FrmAnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private Image[] resimler = new Image[11];
        private int RandomSayıKontrol = 0;
        private int sayac = 0;

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
           
            resimler[0] = Properties.Resources._1;
            resimler[2] = Properties.Resources._2;
            resimler[3] = Properties.Resources._3;
            resimler[4] = Properties.Resources._4;
            resimler[5] = Properties.Resources._5;
            resimler[6] = Properties.Resources._6;
            resimler[7] = Properties.Resources._7;
            resimler[8] = Properties.Resources._8;
            resimler[9] = Properties.Resources._9;
            resimler[10] = Properties.Resources._10;
        }

        private void timerSlayt_Tick(object sender, EventArgs e)
        {
            Random RastgeleSayi = new Random();
            sayac = RastgeleSayi.Next(0, resimler.Length);

            if (RandomSayıKontrol != sayac)
            {
                pctAlbum.Image = resimler[sayac];
                RandomSayıKontrol = sayac;
            }
            else
            {
                RandomSayıKontrol++;
                pctAlbum.Image = resimler[sayac];
            }
        }
    }
}