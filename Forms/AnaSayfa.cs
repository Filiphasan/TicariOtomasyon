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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            var kritik = (from k in db.Urunler
                          select new
                          {
                              k.Id,
                              k.Urun,
                              k.Marka,
                              k.Kategoriler.Kategori,
                              k.SatisFiyat,
                              k.Stok
                          }).Where(x => x.Stok <= 20);
            grdCntrlKritik.DataSource = kritik.ToList();

            grdCntrlFihrist.DataSource = (from f in db.Cariler
                                          select new
                                          {
                                              Musteri = f.Ad + " " + f.Soyad,
                                              f.Il
                                          }).ToList();
            grdCntrlKategoriUrun.DataSource = db.UrunKategori().ToList();

            DateTime today = DateTime.Today;
            grdCntrlYapilacaklar.DataSource = (from y in db.Notlar.Where(t => t.Tarih == today)
                                               select new
                                               {
                                                   y.Baslik,
                                                   y.Icerik
                                               }).ToList();
            gridControl1.DataSource = (from m in db.Mesajlar
                                       orderby m.Id descending
                                       select new
                                       {
                                           Gonderen = m.Ad + " " + m.Soyad,
                                           m.Konu,
                                           m.Mail,
                                           m.Mesaj
                                       }).Take(5).ToList();
        }
        int number = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = string.Format(@"Images\{0}.jpg", number);
            if (number == 9)
            {
                number = 0;
            }
            number++;
        }
    }
}
