using DevExpress.Data.ODataLinq.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon.Forms
{
    public partial class NotListesi : Form
    {
        public NotListesi()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        void Temizle()
        {
            txtEdtNotId.Text = "";
            txtEdtBaslik.Text = "";
            rchTxtIcerik.Text = "";
            txtEdtTarih.Text = "";
            checkEdit1.CheckState = CheckState.Unchecked;
        }
        void ListeleOkunmamis()
        {
            grdCntrlOkunmamis.DataSource = db.Notlar.Where(n => n.Durum == false).ToList();
        }
        void ListeleOkunmus()
        {
            grdCntrlOkunmus.DataSource = db.Notlar.Where(n => n.Durum == true).ToList();
        }
        private void smplBtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void NotListesi_Load(object sender, EventArgs e)
        {
            ListeleOkunmamis();
            ListeleOkunmus();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtNotId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtEdtBaslik.Text = gridView1.GetFocusedRowCellValue("Baslik").ToString();
            rchTxtIcerik.Text = gridView1.GetFocusedRowCellValue("Icerik").ToString();
            if (gridView1.GetFocusedRowCellValue("Tarih") != null)
            {
                txtEdtTarih.Text = gridView1.GetFocusedRowCellValue("Tarih").ToString();
            }
            checkEdit1.CheckState = CheckState.Unchecked;
        }

        private void smpBtnKaydet_Click(object sender, EventArgs e)
        {
            Notlar notlar = new Notlar();
            notlar.Baslik = txtEdtBaslik.Text;
            notlar.Icerik = rchTxtIcerik.Text;
            notlar.Tarih = DateTime.Parse(txtEdtTarih.Text);
            notlar.Durum = false;
            db.Notlar.Add(notlar);
            db.SaveChanges();
            MessageBox.Show("Yeni Not Başarılı Bir Şekilde Eklenmiştir.", "BİLGİ");
            ListeleOkunmamis();
            Temizle();
        }

        private void smplBtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Notu Silmek İstiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (txtEdtNotId.Text != "")
                {
                    int id = int.Parse(txtEdtNotId.Text);
                    var not = db.Notlar.Find(id);
                    db.Notlar.Remove(not);
                    db.SaveChanges();
                    MessageBox.Show("Seçili Not Başarılı Bir Şekilde Silinmiştir.", "BİLGİ");
                    ListeleOkunmamis();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Not Seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void smplBtnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtEdtNotId.Text != "")
            {
                int id = int.Parse(txtEdtNotId.Text);
                var not = db.Notlar.Find(id);
                not.Baslik = txtEdtBaslik.Text;
                not.Icerik = rchTxtIcerik.Text;
                if (txtEdtTarih.Text != "")
                {
                    not.Tarih = DateTime.Parse(txtEdtTarih.Text);
                }
                if (checkEdit1.Checked)
                {
                    not.Durum = true;
                }
                else
                {
                    not.Durum = false;
                }
                db.SaveChanges();
                MessageBox.Show("Seçili Not Başarılı Bir Şekilde Güncellenmiştir.");
                ListeleOkunmamis();
                ListeleOkunmus();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Not Seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
