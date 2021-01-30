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
    public partial class SatisListesi : Form
    {
        public SatisListesi()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void SatisListesi_Load(object sender, EventArgs e)
        {
            var satislar = from s in db.UrunHareket
                           select new
                           {
                               s.HareketId,
                               Urun = s.Urunler.Urun,
                               Musteri = s.Cariler.Ad + " " +s.Cariler.Soyad,
                               Personel = s.Personeller.Ad+" "+s.Personeller.Soyad,
                               s.Tarih,
                               s.Adet,
                               s.Fiyat,
                               s.UrunSeriNo
                           };
            gridControl1.DataSource = satislar.ToList();
        }
    }
}
