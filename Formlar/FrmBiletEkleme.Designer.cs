
namespace OtobüsBiletRezarvasyon.Formlar
{
    partial class FrmBiletEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtKoltukNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCinsiyet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTC = new DevExpress.XtraEditors.TextEdit();
            this.txtBiletNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.timeSeferSaat = new DevExpress.XtraEditors.TimeEdit();
            this.txtAdi = new DevExpress.XtraEditors.TextEdit();
            this.cmbGuzergah = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateSeferTarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtNo = new DevExpress.XtraEditors.TextEdit();
            this.btnBiletKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKoltukNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBiletNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSeferSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGuzergah.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSeferTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSeferTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtKoltukNo);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.cmbCinsiyet);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtTC);
            this.groupControl1.Controls.Add(this.txtBiletNo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.timeSeferSaat);
            this.groupControl1.Controls.Add(this.txtAdi);
            this.groupControl1.Controls.Add(this.cmbGuzergah);
            this.groupControl1.Controls.Add(this.txtSoyad);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.dateSeferTarih);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtNo);
            this.groupControl1.Controls.Add(this.btnBiletKaydet);
            this.groupControl1.Location = new System.Drawing.Point(0, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(232, 428);
            this.groupControl1.TabIndex = 65;
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Location = new System.Drawing.Point(116, 227);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(100, 20);
            this.txtKoltukNo.TabIndex = 70;
            this.txtKoltukNo.TextChanged += new System.EventHandler(this.txtKoltukNo_TextChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(16, 234);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 13);
            this.labelControl10.TabIndex = 69;
            this.labelControl10.Text = "Koltuk No:";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.EditValue = "";
            this.cmbCinsiyet.Location = new System.Drawing.Point(115, 133);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCinsiyet.Properties.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Size = new System.Drawing.Size(100, 20);
            this.cmbCinsiyet.TabIndex = 68;
            this.cmbCinsiyet.TextChanged += new System.EventHandler(this.cmbCinsiyet_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 140);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 67;
            this.labelControl3.Text = "Cinsiyet";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(116, 36);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 3;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // txtBiletNo
            // 
            this.txtBiletNo.Enabled = false;
            this.txtBiletNo.Location = new System.Drawing.Point(116, 336);
            this.txtBiletNo.Name = "txtBiletNo";
            this.txtBiletNo.Size = new System.Drawing.Size(100, 20);
            this.txtBiletNo.TabIndex = 63;
            this.txtBiletNo.TextChanged += new System.EventHandler(this.txtBiletNo_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Adı:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(15, 339);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(40, 13);
            this.labelControl9.TabIndex = 62;
            this.labelControl9.Text = "Bilet No:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Soyadı:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(16, 307);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(53, 13);
            this.labelControl8.TabIndex = 60;
            this.labelControl8.Text = "Sefer Saati";
            // 
            // timeSeferSaat
            // 
            this.timeSeferSaat.EditValue = new System.DateTime(2020, 12, 3, 0, 0, 0, 0);
            this.timeSeferSaat.Location = new System.Drawing.Point(116, 300);
            this.timeSeferSaat.Name = "timeSeferSaat";
            this.timeSeferSaat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeSeferSaat.Size = new System.Drawing.Size(100, 20);
            this.timeSeferSaat.TabIndex = 59;
            this.timeSeferSaat.TextChanged += new System.EventHandler(this.timeSeferSaat_TextChanged);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(116, 67);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 4;
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // cmbGuzergah
            // 
            this.cmbGuzergah.Location = new System.Drawing.Point(116, 192);
            this.cmbGuzergah.Name = "cmbGuzergah";
            this.cmbGuzergah.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGuzergah.Properties.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "Elazığ",
            "İzmir",
            "Adıyaman",
            "Kütahya",
            "Muş"});
            this.cmbGuzergah.Size = new System.Drawing.Size(100, 20);
            this.cmbGuzergah.TabIndex = 58;
            this.cmbGuzergah.TextChanged += new System.EventHandler(this.cmbGuzergah_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(116, 103);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 5;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(16, 273);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(59, 13);
            this.labelControl7.TabIndex = 57;
            this.labelControl7.Text = "Sefer Tarihi:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Telefon No:";
            // 
            // dateSeferTarih
            // 
            this.dateSeferTarih.EditValue = null;
            this.dateSeferTarih.Location = new System.Drawing.Point(116, 266);
            this.dateSeferTarih.Name = "dateSeferTarih";
            this.dateSeferTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSeferTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSeferTarih.Size = new System.Drawing.Size(100, 20);
            this.dateSeferTarih.TabIndex = 56;
            this.dateSeferTarih.TextChanged += new System.EventHandler(this.dateSeferTarih_TextChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 37);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(17, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "TC:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 195);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 13);
            this.labelControl6.TabIndex = 55;
            this.labelControl6.Text = "Güzergah Bilgisi:";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(116, 166);
            this.txtNo.Name = "txtNo";
            this.txtNo.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtNo.Size = new System.Drawing.Size(100, 20);
            this.txtNo.TabIndex = 8;
            this.txtNo.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // btnBiletKaydet
            // 
            this.btnBiletKaydet.Location = new System.Drawing.Point(16, 365);
            this.btnBiletKaydet.Name = "btnBiletKaydet";
            this.btnBiletKaydet.Size = new System.Drawing.Size(200, 37);
            this.btnBiletKaydet.TabIndex = 53;
            this.btnBiletKaydet.Text = "Kaydet";
            this.btnBiletKaydet.Click += new System.EventHandler(this.btnBiletKaydet_Click);
            // 
            // FrmBiletEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 430);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmBiletEkleme";
            this.Text = "Bilet Ekle";
            this.Load += new System.EventHandler(this.FrmBiletEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKoltukNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBiletNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSeferSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGuzergah.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSeferTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSeferTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTC;
        private DevExpress.XtraEditors.TextEdit txtBiletNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TimeEdit timeSeferSaat;
        private DevExpress.XtraEditors.TextEdit txtAdi;
        private DevExpress.XtraEditors.ComboBoxEdit cmbGuzergah;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateSeferTarih;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtNo;
        private DevExpress.XtraEditors.SimpleButton btnBiletKaydet;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCinsiyet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKoltukNo;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}