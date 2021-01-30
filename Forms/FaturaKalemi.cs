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
    public partial class FaturaKalemi : Form
    {
        public FaturaKalemi()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        void Listele()
        {
            var kalemler = from k in db.FaturaDetay
                           select new
                           {
                               k.FaturaDetayId,
                               k.FaturaId,
                               SıraNo = k.FaturaBilgi.SıraNo,
                               k.Urun,
                               k.Adet,
                               k.Fiyat,
                               k.Tutar
                           };
            gridControl1.DataSource = kalemler.ToList();
        }
        void Temizle()
        {
            txtEdtFaturaId.Text = "";
            txtEdtDetayId.Text = "";
            txtEdtAdet.Text = "";
            txtEdtFiyat.Text = "";
            txtEdtTutar.Text = "";
            lookUpEdtUrun.Text = "";
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
        public int faturaId;
        private void FaturaKalemi_Load(object sender, EventArgs e)
        {
            UrunListele();
            Listele();
            txtEdtFaturaId.Text = faturaId.ToString();
        }

        private void smpBtnKaydet_Click(object sender, EventArgs e)
        {
            FaturaDetay detay = new FaturaDetay();
            detay.FaturaId = int.Parse(txtEdtFaturaId.Text);
            detay.Adet = short.Parse(txtEdtAdet.Text);
            detay.Fiyat = decimal.Parse(txtEdtFiyat.Text);
            detay.Tutar = decimal.Parse(txtEdtTutar.Text);
            detay.Urun = lookUpEdtUrun.Text;
            db.FaturaDetay.Add(detay);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalemi Sisteme Başarılı Bir Şekilde Eklenmiştir.", "BİLGİ");
            Listele();
            Temizle();
        }
    }
}
