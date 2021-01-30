using DevExpress.Utils.Extensions;
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
    public partial class UrunIstatistikleri : Form
    {
        public UrunIstatistikleri()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void UrunIstatistikleri_Load(object sender, EventArgs e)
        {
            //Toplam Ürün Sayısı
            labelControl2.Text = db.Urunler.Count().ToString();

            //Toplam Kategori Sayısı
            labelControl3.Text = db.Kategoriler.Count().ToString();

            //Toplam Stok Sayısı
            labelControl5.Text = db.Urunler.Sum(u => u.Stok).ToString();

            //Kritik Stoklu Ürün Sayısı
            labelControl7.Text = db.Urunler.Where(u => u.Stok <= 20).Count().ToString();

            //En Düşük Fiyatlı Ürün
            labelControl11.Text = (from u in db.Urunler
                                   orderby u.SatisFiyat ascending
                                   select u.Urun).FirstOrDefault();

            //En Yüksek Fiyatlı Ürün
            labelControl13.Text = (from u in db.Urunler
                                   orderby u.SatisFiyat descending
                                   select u.Urun).FirstOrDefault();

            //En Fazla Stoklu Ürün
            labelControl19.Text = (from u in db.Urunler
                                   orderby u.Stok descending
                                   select u.Urun).FirstOrDefault();

            //En Az Soklu Ürün
            labelControl17.Text = (from u in db.Urunler
                                   orderby u.Stok ascending
                                   select u.Urun).FirstOrDefault();

            //Beyaz Eşya Sayısı
            labelControl25.Text = db.Urunler.Count(u => u.Kategori == 4).ToString();

            //Bilgisayar Sayısı
            labelControl27.Text = db.Urunler.Count(u => u.Kategori == 1).ToString();

            //Küçük Ev Aleti Sayısı
            labelControl29.Text = db.Urunler.Count(u => u.Kategori == 3).ToString();

            //Toplam Marka Sayısı
            labelControl35.Text = (from u in db.Urunler
                                   select u.Marka).Distinct().Count().ToString();

            //En Fazla Ürünü Olan Marka
            var deger1 = (from d in db.Urunler.GroupBy(u => u.Marka)
                          orderby d.Count() descending
                          select new
                          {
                              d.Key,
                              Toplam = d.Count()
                          }).Select(d => d.Key).FirstOrDefault();
            labelControl39.Text = deger1.ToString();

            //En Fazla Ürün Kategorisi
            var deger = (from d in db.Urunler.GroupBy(u => u.Kategori)
                         select new
                         {
                             d.Key,
                             Toplam = d.Count()
                         }).Select(d => d.Key).FirstOrDefault();
            var kategori = db.Kategoriler.Find(deger);
            labelControl15.Text = kategori.Kategori.ToString();
                

            //Arızalı Ürün Sayısı
            labelControl33.Text = db.UrunKabul.Count().ToString();

        }
    }
}
