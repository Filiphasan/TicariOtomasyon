namespace TeknikServisOtomasyon.Forms
{
    partial class FaturaKalemi
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtDetayId = new DevExpress.XtraEditors.TextEdit();
            this.smplBtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.smplBtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.smplBtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtFaturaId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtAdet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.smpBtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdtUrun = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtDetayId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtFaturaId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdtUrun.Properties)).BeginInit();
            this.SuspendLayout();
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
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1301, 821);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(119, 83);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 19);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Detay Id:";
            // 
            // txtEdtDetayId
            // 
            this.txtEdtDetayId.Enabled = false;
            this.txtEdtDetayId.Location = new System.Drawing.Point(197, 80);
            this.txtEdtDetayId.Name = "txtEdtDetayId";
            this.txtEdtDetayId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtDetayId.Properties.Appearance.Options.UseFont = true;
            this.txtEdtDetayId.Size = new System.Drawing.Size(214, 26);
            this.txtEdtDetayId.TabIndex = 1;
            // 
            // smplBtnTemizle
            // 
            this.smplBtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smplBtnTemizle.Appearance.Options.UseFont = true;
            this.smplBtnTemizle.ImageOptions.Image = global::TeknikServisOtomasyon.Properties.Resources.icons8_broom_32px;
            this.smplBtnTemizle.Location = new System.Drawing.Point(276, 483);
            this.smplBtnTemizle.Name = "smplBtnTemizle";
            this.smplBtnTemizle.Size = new System.Drawing.Size(177, 51);
            this.smplBtnTemizle.TabIndex = 11;
            this.smplBtnTemizle.Text = "Temizle";
            // 
            // smplBtnGuncelle
            // 
            this.smplBtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smplBtnGuncelle.Appearance.Options.UseFont = true;
            this.smplBtnGuncelle.ImageOptions.Image = global::TeknikServisOtomasyon.Properties.Resources.icons8_update_32px;
            this.smplBtnGuncelle.Location = new System.Drawing.Point(62, 483);
            this.smplBtnGuncelle.Name = "smplBtnGuncelle";
            this.smplBtnGuncelle.Size = new System.Drawing.Size(177, 51);
            this.smplBtnGuncelle.TabIndex = 10;
            this.smplBtnGuncelle.Text = "Güncelle";
            // 
            // smplBtnSil
            // 
            this.smplBtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smplBtnSil.Appearance.Options.UseFont = true;
            this.smplBtnSil.ImageOptions.Image = global::TeknikServisOtomasyon.Properties.Resources.icons8_delete_bin_32px;
            this.smplBtnSil.Location = new System.Drawing.Point(276, 396);
            this.smplBtnSil.Name = "smplBtnSil";
            this.smplBtnSil.Size = new System.Drawing.Size(177, 51);
            this.smplBtnSil.TabIndex = 9;
            this.smplBtnSil.Text = "Sil";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(115, 299);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 19);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Fatura Id:";
            // 
            // txtEdtFaturaId
            // 
            this.txtEdtFaturaId.Location = new System.Drawing.Point(197, 296);
            this.txtEdtFaturaId.Name = "txtEdtFaturaId";
            this.txtEdtFaturaId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtFaturaId.Properties.Appearance.Options.UseFont = true;
            this.txtEdtFaturaId.Size = new System.Drawing.Size(214, 26);
            this.txtEdtFaturaId.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(141, 256);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 19);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Tutar:";
            // 
            // txtEdtTutar
            // 
            this.txtEdtTutar.Location = new System.Drawing.Point(197, 253);
            this.txtEdtTutar.Name = "txtEdtTutar";
            this.txtEdtTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtTutar.Properties.Appearance.Options.UseFont = true;
            this.txtEdtTutar.Size = new System.Drawing.Size(214, 26);
            this.txtEdtTutar.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(146, 213);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Fiyat:";
            // 
            // txtEdtFiyat
            // 
            this.txtEdtFiyat.Location = new System.Drawing.Point(197, 210);
            this.txtEdtFiyat.Name = "txtEdtFiyat";
            this.txtEdtFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtFiyat.Properties.Appearance.Options.UseFont = true;
            this.txtEdtFiyat.Size = new System.Drawing.Size(214, 26);
            this.txtEdtFiyat.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(146, 171);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Adet:";
            // 
            // txtEdtAdet
            // 
            this.txtEdtAdet.Location = new System.Drawing.Point(197, 168);
            this.txtEdtAdet.Name = "txtEdtAdet";
            this.txtEdtAdet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtAdet.Properties.Appearance.Options.UseFont = true;
            this.txtEdtAdet.Size = new System.Drawing.Size(214, 26);
            this.txtEdtAdet.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(144, 128);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ürün:";
            // 
            // smpBtnKaydet
            // 
            this.smpBtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smpBtnKaydet.Appearance.Options.UseFont = true;
            this.smpBtnKaydet.ImageOptions.Image = global::TeknikServisOtomasyon.Properties.Resources.icons8_save_32px;
            this.smpBtnKaydet.Location = new System.Drawing.Point(62, 396);
            this.smpBtnKaydet.Name = "smpBtnKaydet";
            this.smpBtnKaydet.Size = new System.Drawing.Size(177, 51);
            this.smpBtnKaydet.TabIndex = 8;
            this.smpBtnKaydet.Text = "Kaydet";
            this.smpBtnKaydet.Click += new System.EventHandler(this.smpBtnKaydet_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEdtUrun);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtEdtDetayId);
            this.groupControl1.Controls.Add(this.smplBtnTemizle);
            this.groupControl1.Controls.Add(this.smplBtnGuncelle);
            this.groupControl1.Controls.Add(this.smplBtnSil);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtEdtFaturaId);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtEdtTutar);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtEdtFiyat);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtEdtAdet);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.smpBtnKaydet);
            this.groupControl1.Location = new System.Drawing.Point(1307, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(504, 821);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Fatura Kalem İşlemleri";
            // 
            // lookUpEdtUrun
            // 
            this.lookUpEdtUrun.Location = new System.Drawing.Point(197, 125);
            this.lookUpEdtUrun.Name = "lookUpEdtUrun";
            this.lookUpEdtUrun.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdtUrun.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdtUrun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdtUrun.Properties.DisplayMember = "Urun";
            this.lookUpEdtUrun.Properties.NullText = "";
            this.lookUpEdtUrun.Properties.ValueMember = "Id";
            this.lookUpEdtUrun.Size = new System.Drawing.Size(214, 26);
            this.lookUpEdtUrun.TabIndex = 14;
            // 
            // FaturaKalemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 821);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FaturaKalemi";
            this.Text = "Fatura Kalemi";
            this.Load += new System.EventHandler(this.FaturaKalemi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtDetayId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtFaturaId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdtUrun.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtEdtDetayId;
        private DevExpress.XtraEditors.SimpleButton smplBtnTemizle;
        private DevExpress.XtraEditors.SimpleButton smplBtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton smplBtnSil;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEdtFaturaId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEdtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtEdtFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEdtAdet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton smpBtnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdtUrun;
    }
}