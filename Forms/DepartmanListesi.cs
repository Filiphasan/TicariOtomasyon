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
    public partial class DepartmanListesi : Form
    {
        public DepartmanListesi()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();

        void Listele()
        {
            var degerler = from d in db.Departmanlar
                           select new
                           {
                               d.Id,
                               d.Ad,
                               d.Aciklama
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        void Temizle()
        {
            txtEdtAd.Text = "";
            txtEdtDepartmanId.Text = "";
            rchTxtAciklama.Text = "";
        }
        private void DepartmanListesi_Load(object sender, EventArgs e)
        {
            Listele();

            //Toplam Departman Sayısı
            labelControl12.Text = db.Departmanlar.Count().ToString();

            //Toplam Personel Sayısı
            labelControl14.Text = db.Personeller.Count().ToString();
        }

        private void smpBtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtEdtAd.Text.Length <= 50 && txtEdtAd.Text != "")
            {
                Departmanlar departmanlar = new Departmanlar();
                departmanlar.Ad = txtEdtAd.Text;
                departmanlar.Aciklama = rchTxtAciklama.Text;
                db.Departmanlar.Add(departmanlar);
                db.SaveChanges();
                MessageBox.Show("Yeni Departman Başarılı Bir Şekilde Eklenmiştir.", "Uyarı");
                Temizle();
                Listele();
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı. Lütfen Girdiğiniz Değerleri Kontrol Ediniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
                Listele();
            }
        }

        private void smplBtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtDepartmanId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtEdtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            if (gridView1.GetFocusedRowCellValue("Aciklama") != null)
            {
                rchTxtAciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
            }
            else
            {
                rchTxtAciklama.Text = "";
            }
        }

        private void smplBtnSil_Click(object sender, EventArgs e)
        {
            if (txtEdtDepartmanId.Text == "")
            {
                MessageBox.Show("Lütfen Bir Departman Seçiniz!");
            }
            else
            {
                int id = int.Parse(txtEdtDepartmanId.Text);

                var deger = db.Departmanlar.Find(id);
                db.Departmanlar.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Departman Başarılı Bir Şekilde Silinmiştir.", "Uyarı");
                Temizle();
                Listele();
            }
        }

        private void smplBtnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtEdtDepartmanId.Text != "")
            {
                int id = int.Parse(txtEdtDepartmanId.Text);
                var departman = db.Departmanlar.Find(id);
                departman.Ad = txtEdtAd.Text;
                departman.Aciklama = rchTxtAciklama.Text;
                db.SaveChanges();
                MessageBox.Show("Departman Bilgileri Başarılı Bir Şekilde Güncellenmiştir.","UYARI");
                Temizle();
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Departman Seçiniz!");
            }
        }
    }
}
