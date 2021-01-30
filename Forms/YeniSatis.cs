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
    public partial class YeniSatis : Form
    {
        public YeniSatis()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UrunHareket urunHareket = new UrunHareket();
            urunHareket.Urun = int.Parse(lookUpEdtUrun.EditValue.ToString());
            urunHareket.Musteri = int.Parse(lookUpEdtCari.EditValue.ToString());
            urunHareket.Personel = short.Parse(lookUpEdtPersonel.EditValue.ToString());
            urunHareket.Tarih = DateTime.Parse(txtEdtTarih.Text);
            urunHareket.Adet = short.Parse(txtEdtAdet.Text);
            urunHareket.Fiyat = decimal.Parse(txtEdtFiyat.Text);
            urunHareket.UrunSeriNo = txtEdtSeriNo.Text;
            db.UrunHareket.Add(urunHareket);
            db.SaveChanges();
            MessageBox.Show("Yeni Ürün Satışı Başarılı Bir Şekilde Gerçekleşmiştir.", "BİLGİ");

        }
        void UrunListele()
        {
            lookUpEdtUrun.Properties.DataSource = (from u in db.Urunler
                                                   select new
                                                   {
                                                       u.Id,
                                                       u.Urun
                                                   }).ToList();
        }
        void CariListele()
        {
            lookUpEdtCari.Properties.DataSource = (from c in db.Cariler
                                                   select new
                                                   {
                                                       c.Id,
                                                       Musteri = c.Ad + " " + c.Soyad
                                                   }).ToList();
        }
        void PersonelListele()
        {
            lookUpEdtPersonel.Properties.DataSource = (from p in db.Personeller
                                                       select new
                                                       {
                                                           p.Id,
                                                           Personel = p.Ad + " " + p.Soyad
                                                       }).ToList();
        }
        private void YeniSatis_Load(object sender, EventArgs e)
        {
            UrunListele();
            CariListele();
            PersonelListele();
        }
    }
}
