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
    public partial class FaturaCıktı : Form
    {
        public FaturaCıktı()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        public int id;
        private void FaturaCıktı_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from f in db.FaturaBilgi.Where(x => x.Id == id)
                                       select new
                                       {
                                           f.Id,
                                           f.Seri,
                                           f.SıraNo,
                                           f.Tarih,
                                           f.Saat,
                                           f.VergiDaire,
                                           Cari = f.Cariler.Ad + " " + f.Cariler.Soyad,
                                           Personel = f.Personeller.Ad + " " + f.Personeller.Soyad
                                       }).ToList();
            gridControl2.DataSource = (from k in db.FaturaDetay.Where(x => x.FaturaId == id)
                                       select new
                                       {
                                           k.FaturaDetayId,
                                           k.FaturaId,
                                           k.Urun,
                                           k.Adet,
                                           k.Fiyat,
                                           k.Tutar
                                       }).ToList();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
