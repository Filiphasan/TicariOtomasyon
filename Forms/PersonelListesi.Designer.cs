namespace TeknikServisOtomasyon.Forms
{
    partial class PersonelListesi
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
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtPersonelId = new DevExpress.XtraEditors.TextEdit();
            this.smplBtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.smplBtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.smplBtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdtDepartman = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtFotograf = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtAd = new DevExpress.XtraEditors.TextEdit();
            this.smpBtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtEdtTelefon = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtPersonelId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdtDepartman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtFotograf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtTelefon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(103, 83);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 19);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Personel Id:";
            // 
            // txtEdtPersonelId
            // 
            this.txtEdtPersonelId.Enabled = false;
            this.txtEdtPersonelId.Location = new System.Drawing.Point(197, 80);
            this.txtEdtPersonelId.Name = "txtEdtPersonelId";
            this.txtEdtPersonelId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtPersonelId.Properties.Appearance.Options.UseFont = true;
            this.txtEdtPersonelId.Size = new System.Drawing.Size(214, 26);
            this.txtEdtPersonelId.TabIndex = 1;
            // 
            // smplBtnTemizle
            // 
            this.smplBtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smplBtnTemizle.Appearance.Options.UseFont = true;
            this.smplBtnTemizle.ImageOptions.Image = global::TeknikServisOtomasyon.Properties.Resources.icons8_broom_32px;
            this.smplBtnTemizle.Location = new System.Drawing.Point(263, 535);
            this.smplBtnTemizle.Name = "smplBtnTemizle";
            this.smplBtnTemizle.Size = new System.Drawing.Size(177, 51);
            this.smplBtnTemizle.TabIndex = 11;
            this.smplBtnTemizle.Text = "Temizle";
            this.smplBtnTemizle.Click += new System.EventHandler(this.smplBtnTemizle_Click);
            // 
            // smplBtnGuncelle
            // 
            this.smplBtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smplBtnGuncelle.Appearance.Options.UseFont = true;
            this.smplBtnGuncelle.ImageOptions.Image = global::TeknikServisOtomasyon.Properties.Resources.icons8_update_32px;
            this.smplBtnGuncelle.Location = new System.Drawing.Point(49, 535);
            this.smplBtnGuncelle.Name = "smplBtnGuncelle";
            this.smplBtnGuncelle.Size = new System.Drawing.Size(177, 51);
            this.smplBtnGuncelle.TabIndex = 10;
            this.smplBtnGuncelle.Text = "Güncelle";
            this.smplBtnGuncelle.Click += new System.EventHandler(this.smplBtnGuncelle_Click);
            // 
            // smplBtnSil
            // 
            this.smplBtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smplBtnSil.Appearance.Options.UseFont = true;
            this.smplBtnSil.ImageOptions.Image = global::TeknikServisOtomasyon.Properties.Resources.icons8_delete_bin_32px;
            this.smplBtnSil.Location = new System.Drawing.Point(263, 448);
            this.smplBtnSil.Name = "smplBtnSil";
            this.smplBtnSil.Size = new System.Drawing.Size(177, 51);
            this.smplBtnSil.TabIndex = 9;
            this.smplBtnSil.Text = "Sil";
            this.smplBtnSil.Click += new System.EventHandler(this.smplBtnSil_Click);
            // 
            // lookUpEdtDepartman
            // 
            this.lookUpEdtDepartman.Location = new System.Drawing.Point(197, 210);
            this.lookUpEdtDepartman.Name = "lookUpEdtDepartman";
            this.lookUpEdtDepartman.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdtDepartman.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdtDepartman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdtDepartman.Properties.DisplayMember = "Ad";
            this.lookUpEdtDepartman.Properties.NullText = "";
            this.lookUpEdtDepartman.Properties.ValueMember = "Id";
            this.lookUpEdtDepartman.Size = new System.Drawing.Size(214, 26);
            this.lookUpEdtDepartman.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(130, 343);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 19);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Telefon:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(155, 299);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 19);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Mail:";
            // 
            // txtEdtMail
            // 
            this.txtEdtMail.Location = new System.Drawing.Point(197, 296);
            this.txtEdtMail.Name = "txtEdtMail";
            this.txtEdtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtMail.Properties.Appearance.Options.UseFont = true;
            this.txtEdtMail.Size = new System.Drawing.Size(214, 26);
            this.txtEdtMail.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(124, 256);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 19);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Fotoğraf:";
            // 
            // txtEdtFotograf
            // 
            this.txtEdtFotograf.Location = new System.Drawing.Point(197, 253);
            this.txtEdtFotograf.Name = "txtEdtFotograf";
            this.txtEdtFotograf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtFotograf.Properties.Appearance.Options.UseFont = true;
            this.txtEdtFotograf.Size = new System.Drawing.Size(214, 26);
            this.txtEdtFotograf.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(105, 213);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Departman:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(140, 171);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Soyad:";
            // 
            // txtEdtSoyad
            // 
            this.txtEdtSoyad.Location = new System.Drawing.Point(197, 168);
            this.txtEdtSoyad.Name = "txtEdtSoyad";
            this.txtEdtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtEdtSoyad.Size = new System.Drawing.Size(214, 26);
            this.txtEdtSoyad.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(163, 128);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ad:";
            // 
            // txtEdtAd
            // 
            this.txtEdtAd.Location = new System.Drawing.Point(197, 125);
            this.txtEdtAd.Name = "txtEdtAd";
            this.txtEdtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtAd.Properties.Appearance.Options.UseFont = true;
            this.txtEdtAd.Size = new System.Drawing.Size(214, 26);
            this.txtEdtAd.TabIndex = 2;
            // 
            // smpBtnKaydet
            // 
            this.smpBtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smpBtnKaydet.Appearance.Options.UseFont = true;
            this.smpBtnKaydet.ImageOptions.Image = global::TeknikServisOtomasyon.Properties.Resources.icons8_save_32px;
            this.smpBtnKaydet.Location = new System.Drawing.Point(49, 448);
            this.smpBtnKaydet.Name = "smpBtnKaydet";
            this.smpBtnKaydet.Size = new System.Drawing.Size(177, 51);
            this.smpBtnKaydet.TabIndex = 8;
            this.smpBtnKaydet.Text = "Kaydet";
            this.smpBtnKaydet.Click += new System.EventHandler(this.smpBtnKaydet_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtEdtTelefon);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtEdtPersonelId);
            this.groupControl1.Controls.Add(this.smplBtnTemizle);
            this.groupControl1.Controls.Add(this.smplBtnGuncelle);
            this.groupControl1.Controls.Add(this.smplBtnSil);
            this.groupControl1.Controls.Add(this.lookUpEdtDepartman);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtEdtMail);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtEdtFotograf);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtEdtSoyad);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtEdtAd);
            this.groupControl1.Controls.Add(this.smpBtnKaydet);
            this.groupControl1.Location = new System.Drawing.Point(1307, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(504, 821);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Personel İşlemleri";
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1301, 821);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // txtEdtTelefon
            // 
            this.txtEdtTelefon.Location = new System.Drawing.Point(197, 340);
            this.txtEdtTelefon.Name = "txtEdtTelefon";
            this.txtEdtTelefon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtTelefon.Properties.Appearance.Options.UseFont = true;
            this.txtEdtTelefon.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtEdtTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtEdtTelefon.Size = new System.Drawing.Size(214, 26);
            this.txtEdtTelefon.TabIndex = 14;
            // 
            // PersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 821);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "PersonelListesi";
            this.Text = "PersonelListesi";
            this.Load += new System.EventHandler(this.PersonelListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtPersonelId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdtDepartman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtFotograf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtTelefon.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtEdtPersonelId;
        private DevExpress.XtraEditors.SimpleButton smplBtnTemizle;
        private DevExpress.XtraEditors.SimpleButton smplBtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton smplBtnSil;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdtDepartman;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEdtMail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEdtFotograf;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEdtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEdtAd;
        private DevExpress.XtraEditors.SimpleButton smpBtnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtEdtTelefon;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}