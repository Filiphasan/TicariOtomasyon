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
    public partial class ArizaliUrunAciklama : Form
    {
        public ArizaliUrunAciklama()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UrunTakip takip = new UrunTakip();
            takip.SeriNo = txtEdtSeriNo.Text;
            takip.Tarih = DateTime.Parse(txtEdtTarih.Text);
            takip.Aciklama = rchTxtAciklama.Text;
            db.UrunTakip.Add(takip);
            db.SaveChanges();
            MessageBox.Show("Arızalı Ürün Açıklaması Başarılı Bir Şekilde Kaydedilmiştir.", "BİLGİ");
        }
    }
}
