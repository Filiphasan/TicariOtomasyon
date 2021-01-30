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
    public partial class YeniUrun : Form
    {
        public YeniUrun()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["YeniUrun"].Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["YeniUrun"].Close();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.Urun = txtEdtUrunAd.Text;
            urunler.Marka = txtEdtMarka.Text;
            urunler.AlisFiyat = decimal.Parse(txtEdtAlisFiyat.Text);
            urunler.SatisFiyat = decimal.Parse(txtEdtSatisFiyat.Text);
            urunler.Stok = short.Parse(txtEdtStok.Text);
            urunler.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.Urunler.Add(urunler);
            db.SaveChanges();
            MessageBox.Show("Yeni Ürün Başarılı Bir Şekilde Eklenmiştir.");
        }

        private void YeniUrun_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.Kategoriler
                           select new
                           {
                               k.Id,
                               k.Kategori
                           };
            lookUpEdit1.Properties.DataSource = degerler.ToList();
        }

        private void txtEdtUrunAd_Click(object sender, EventArgs e)
        {
            //txtEdtUrunAd.Text = "";
            //txtEdtUrunAd.Focus();
        }
    }
}
