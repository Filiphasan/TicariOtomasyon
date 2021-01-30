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
    public partial class UrunListesi : Form
    {
        public UrunListesi()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void UrunListesi_Load(object sender, EventArgs e)
        {
            Listele();
            KategoriListele();
        }

        private void KategoriListele()
        {
            var degerler = from k in db.Kategoriler
                           select new
                           {
                               k.Id,
                               k.Kategori
                           };
            lookUpEdit1.Properties.DataSource = degerler.ToList();
        }

        void Listele()
        {
            var degerler = from u in db.Urunler
                           select new
                           {
                               u.Id,
                               u.Urun,
                               u.Marka,
                               Kategori = u.Kategoriler.Kategori,
                               u.Stok,
                               u.AlisFiyat,
                               u.SatisFiyat

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        void Temizle()
        {
            txtEdtUrunId.Text = "";
            txtEdtAlisFiyat.Text = "";
            txtEdtMarka.Text = "";
            txtEdtSatisFiyat.Text = "";
            txtEdtStok.Text = "";
            txtEdtUrunAdı.Text = "";
        }
        private void smplBtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void smpBtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Urunler urunler = new Urunler();
                urunler.Urun = txtEdtUrunAdı.Text;
                urunler.Marka = txtEdtMarka.Text;
                urunler.AlisFiyat = decimal.Parse(txtEdtAlisFiyat.Text);
                urunler.SatisFiyat = decimal.Parse(txtEdtSatisFiyat.Text);
                urunler.Stok = short.Parse(txtEdtStok.Text);
                urunler.Durum = false;
                urunler.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.Urunler.Add(urunler);
                db.SaveChanges();
                Temizle();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Girdiğiniz Değerleri Kontrol Ediniz! Lütfen Boş Alan Bırakmayınız!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtUrunId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtEdtUrunAdı.Text = gridView1.GetFocusedRowCellValue("Urun").ToString();
            txtEdtMarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
            txtEdtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("AlisFiyat").ToString();
            txtEdtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SatisFiyat").ToString();
            txtEdtStok.Text = gridView1.GetFocusedRowCellValue("Stok").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Kategori").ToString();
        }

        private void smplBtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ürünü Gerçekten Silmek İstiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtEdtUrunId.Text != "")
                {
                    int id = int.Parse(txtEdtUrunId.Text);
                    var urun = db.Urunler.Find(id);
                    db.Urunler.Remove(urun);
                    db.SaveChanges();
                    MessageBox.Show("Ürün Başarılı Bir Şekilde Silinmiştir.", "Bilgi");
                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Lütfen Ürün Seçimi Yapınız.", "Bilgi");
                }
            }
        }

        private void smplBtnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtEdtUrunId.Text != "")
            {
                int id = int.Parse(txtEdtUrunId.Text);

                var urun = db.Urunler.Find(id);
                urun.Urun = txtEdtUrunAdı.Text;
                urun.Marka = txtEdtMarka.Text;
                urun.AlisFiyat = decimal.Parse(txtEdtAlisFiyat.Text);
                urun.SatisFiyat = decimal.Parse(txtEdtSatisFiyat.Text);
                urun.Stok = short.Parse(txtEdtStok.Text);
                urun.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Ürün Başarılı Bir Şekilde Güncellenmiştir.", "Bilgi");
                Temizle();
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen Ürün Seçimi Yapınız.", "Bilgi");
            }
        }
    }
}
