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
    public partial class KategoriListesi : Form
    {
        public KategoriListesi()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        void Temizle()
        {
            txtEdtKategoriAdı.Text = "";
            txtEdtKategoriId.Text = "";
        }
        void Listele()
        {
            var kategoriler = from k in db.Kategoriler
                              select new
                              {
                                  k.Id,
                                  k.Kategori
                              };
            gridControl1.DataSource = kategoriler.ToList();
        }
        private void smplBtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void KategoriListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void smpBtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtEdtKategoriAdı.Text != "" && txtEdtKategoriAdı.Text.Length <= 30)
            {
                Kategoriler kategoriler = new Kategoriler();
                kategoriler.Kategori = txtEdtKategoriAdı.Text;
                db.Kategoriler.Add(kategoriler);
                db.SaveChanges();
                MessageBox.Show("Yeni Kategori Başarılı Bir Şekilde Eklenmiştir.");
                Temizle();
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen Girdiğniz Değerleri Kontrol Ediniz! Kategori 30 Karekterden fazla olamaz.");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtKategoriId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtEdtKategoriAdı.Text = gridView1.GetFocusedRowCellValue("Kategori").ToString();
        }

        private void smplBtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kategoriyi Gerçekten Silmek İstiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                if (txtEdtKategoriId.Text != "")
                {
                    int id = int.Parse(txtEdtKategoriId.Text);

                    var kategori = db.Kategoriler.Find(id);
                    db.Kategoriler.Remove(kategori);
                    db.SaveChanges();
                    MessageBox.Show("Kategori Başarılı Bir Şekilde Silinmiştir.", "Bilgi");
                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Kategori Seçiniz!", "Uyarı");
                }
            }
        }

        private void smplBtnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtEdtKategoriId.Text != "")
            {
                int id = int.Parse(txtEdtKategoriId.Text);

                var kategori = db.Kategoriler.Find(id);
                kategori.Kategori = txtEdtKategoriAdı.Text;
                db.SaveChanges();
                MessageBox.Show("Kategori Başarılı Bir Şekilde Güncellenmiştir.", "Bilgi");
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kategori Seçiniz!", "Uyarı");
            }
        }
    }
}
