
namespace OtobüsBiletRezarvasyon.Formlar
{
    partial class FrmAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.timerSlayt = new System.Windows.Forms.Timer(this.components);
            this.pctAlbum = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlbum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSlayt
            // 
            this.timerSlayt.Enabled = true;
            this.timerSlayt.Interval = 2000;
            this.timerSlayt.Tick += new System.EventHandler(this.timerSlayt_Tick);
            // 
            // pctAlbum
            // 
            this.pctAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctAlbum.Location = new System.Drawing.Point(0, 0);
            this.pctAlbum.Name = "pctAlbum";
            this.pctAlbum.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pctAlbum.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pctAlbum.Size = new System.Drawing.Size(1366, 598);
            this.pctAlbum.TabIndex = 0;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 598);
            this.Controls.Add(this.pctAlbum);
            this.Name = "FrmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlbum.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PictureEdit pctAlbum;
        public System.Windows.Forms.Timer timerSlayt;
    }
}