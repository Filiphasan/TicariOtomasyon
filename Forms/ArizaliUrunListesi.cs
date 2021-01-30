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
    public partial class ArizaliUrunListesi : Form
    {
        public ArizaliUrunListesi()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        void Listele()
        {
            var liste = from a in db.UrunKabul
                        select new
                        {
                            a.IslemId,
                            Cari = a.Cariler.Ad +" "+ a.Cariler.Soyad,
                            Personel = a.Personeller.Ad +" "+ a.Personeller.Soyad,
                            a.GelisTarih,
                            a.CikisTarih,
                            a.UrunSeriNo
                        };
            gridControl1.DataSource = liste.ToList();
        }
        private void ArizaliUrunListesi_Load(object sender, EventArgs e)
        {
            Listele();

            //Toplam Ürün Sayısı
            labelControl11.Text = db.Urunler.Count().ToString();

            //Mevcut Arızalı Ürün Sayısı
            labelControl3.Text = db.UrunKabul.Count().ToString();

            //Tamir Edilmiş Ürün Sayısı
            labelControl5.Text = db.UrunKabul.Where(u => u.CikisTarih != null).Count().ToString();

            //En Fazla Arızalanan Marka
            
        }
    }
}
