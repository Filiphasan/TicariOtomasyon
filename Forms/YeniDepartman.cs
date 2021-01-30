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
    public partial class YeniDepartman : Form
    {
        public YeniDepartman()
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
            Departmanlar departmanlar = new Departmanlar();
            departmanlar.Ad = txtEdtAd.Text;
            departmanlar.Aciklama = rchTxtAciklama.Text;
            db.Departmanlar.Add(departmanlar);
            db.SaveChanges();
            MessageBox.Show("Yeni Departman Başarılı Bir Şekilde Eklenmiştir.");
        }
    }
}
