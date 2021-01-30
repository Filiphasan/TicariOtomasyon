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
    public partial class ArizaliUrunKaydı : Form
    {
        public ArizaliUrunKaydı()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UrunKabul urunKabul = new UrunKabul();
            urunKabul.Cari = int.Parse(txtEdtMusteri.Text);
            urunKabul.Personel = short.Parse(txtEdtPersonel.Text);
            urunKabul.GelisTarih = DateTime.Parse(txtEdtGelisTarihi.Text);
            urunKabul.UrunSeriNo = txtEdtSeriNo.Text;
            db.UrunKabul.Add(urunKabul);
            db.SaveChanges();
            MessageBox.Show("Arızalı Ürün Kaydı Başarılı Bir Şekilde Gerçekleşmiştir.","BİLGİ");
        }
    }
}
