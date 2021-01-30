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
    public partial class YeniNot : Form
    {
        public YeniNot()
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
            Notlar notlar = new Notlar();
            notlar.Baslik = txtEdtBaslik.Text;
            notlar.Icerik = rchTxtIcerik.Text;
            notlar.Tarih = DateTime.Parse(txtEdtTarih.Text);
            notlar.Durum = false;
            db.Notlar.Add(notlar);
            db.SaveChanges();
            MessageBox.Show("Yeni Not Başarılı Bir Şekilde Eklenmiştir.","BİLGİ");
        }
    }
}
