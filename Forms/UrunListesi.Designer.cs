namespace TeknikServisOtomasyon.Forms
{
    partial class UrunListesi
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtUrunId = new DevExpress.XtraEditors.TextEdit();
            this.smplBtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.smplBtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.smplBtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtStok = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtUrunAdı = new DevExpress.XtraEditors.TextEdit();
            this.smpBtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtUrunId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtUrunAdı.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1301, 821);
            this.gridControl1.TabIndex = 0;
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtEdtUrunId);
            this.groupControl1.Controls.Add(this.smplBtnTemizle);
            this.groupControl1.Controls.Add(this.smplBtnGuncelle);
            this.groupControl1.Controls.Add(this.smplBtnSil);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtEdtStok);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtEdtSatisFiyat);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtEdtAlisFiyat);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtEdtMarka);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtEdtUrunAdı);
            this.groupControl1.Controls.Add(this.smpBtnKaydet);
            this.groupControl1.Location = new System.Drawing.Point(1307, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(504, 821);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Ürün İşlemleri";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(122, 83);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 19);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Ürün Id:";
            // 
            // txtEdtUrunId
            // 
            this.txtEdtUrunId.Enabled = false;
            this.txtEdtUrunId.Location = new System.Drawing.Point(197, 80);
            this.txtEdtUrunId.Name = "txtEdtUrunId";
            this.txtEdtUrunId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtUrunId.Properties.Appearance.Options.UseFont = true;
            this.txtEdtUrunId.Size = new System.Drawing.Size(214, 26);
            this.txtEdtUrunId.TabIndex = 1;
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
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(197, 340);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "Kategori";
            this.lookUpEdit1.Properties.NullText = "Kategori Seçin";
            this.lookUpEdit1.Properties.ValueMember = "Id";
            this.lookUpEdit1.Size = new System.Drawing.Size(214, 26);
            this.lookUpEdit1.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(119, 343);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 19);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Kategori:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(146, 299);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 19);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Stok:";
            // 
            // txtEdtStok
            // 
            this.txtEdtStok.Location = new System.Drawing.Point(197, 296);
            this.txtEdtStok.Name = "txtEdtStok";
            this.txtEdtStok.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtStok.Properties.Appearance.Options.UseFont = true;
            this.txtEdtStok.Size = new System.Drawing.Size(214, 26);
            this.txtEdtStok.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(102, 256);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 19);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Satış Fiyatı:";
            // 
            // txtEdtSatisFiyat
            // 
            this.txtEdtSatisFiyat.Location = new System.Drawing.Point(197, 253);
            this.txtEdtSatisFiyat.Name = "txtEdtSatisFiyat";
            this.txtEdtSatisFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtSatisFiyat.Properties.Appearance.Options.UseFont = true;
            this.txtEdtSatisFiyat.Size = new System.Drawing.Size(214, 26);
            this.txtEdtSatisFiyat.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(109, 213);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Alış Fiyatı:";
            // 
            // txtEdtAlisFiyat
            // 
            this.txtEdtAlisFiyat.Location = new System.Drawing.Point(197, 210);
            this.txtEdtAlisFiyat.Name = "txtEdtAlisFiyat";
            this.txtEdtAlisFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtAlisFiyat.Properties.Appearance.Options.UseFont = true;
            this.txtEdtAlisFiyat.Size = new System.Drawing.Size(214, 26);
            this.txtEdtAlisFiyat.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(135, 171);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Marka:";
            // 
            // txtEdtMarka
            // 
            this.txtEdtMarka.Location = new System.Drawing.Point(197, 168);
            this.txtEdtMarka.Name = "txtEdtMarka";
            this.txtEdtMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtMarka.Properties.Appearance.Options.UseFont = true;
            this.txtEdtMarka.Size = new System.Drawing.Size(214, 26);
            this.txtEdtMarka.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(113, 128);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ürün Adı:";
            // 
            // txtEdtUrunAdı
            // 
            this.txtEdtUrunAdı.Location = new System.Drawing.Point(197, 125);
            this.txtEdtUrunAdı.Name = "txtEdtUrunAdı";
            this.txtEdtUrunAdı.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEdtUrunAdı.Properties.Appearance.Options.UseFont = true;
            this.txtEdtUrunAdı.Size = new System.Drawing.Size(214, 26);
            this.txtEdtUrunAdı.TabIndex = 2;
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
            // UrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 821);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "UrunListesi";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.UrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtUrunId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtUrunAdı.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton smplBtnTemizle;
        private DevExpress.XtraEditors.SimpleButton smplBtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton smplBtnSil;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEdtStok;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEdtSatisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtEdtAlisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEdtMarka;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEdtUrunAdı;
        private DevExpress.XtraEditors.SimpleButton smpBtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtEdtUrunId;
    }
}