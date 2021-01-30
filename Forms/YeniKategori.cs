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
    public partial class YeniKategori : Form
    {
        public YeniKategori()
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
            if (txtEdtKategoriAd.Text.Length <= 30 && txtEdtKategoriAd.Text != "")
            {
                Kategoriler kategoriler = new Kategoriler();
                kategoriler.Kategori = txtEdtKategoriAd.Text;
                db.Kategoriler.Add(kategoriler);
                db.SaveChanges();
                MessageBox.Show("Yeni Kategori Başarılı Bir Şekilde Eklenmiştir.", "Bilgi");
            }
            else
            {
                MessageBox.Show("Lütfen Girdiğiniz Değerleri Kontrol Ediniz! 30 karekterden fazla veya boş olamaz!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
