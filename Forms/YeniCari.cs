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
    public partial class YeniCari : Form
    {
        public YeniCari()
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
            Cariler cariler = new Cariler();
            cariler.Ad = txtEdtAd.Text;
            cariler.Soyad = txtEdtSoyad.Text;
            cariler.Il = lookUpEdtIl.Text;
            cariler.Ilce = lookUpEdtIlce.Text;
            db.Cariler.Add(cariler);
            db.SaveChanges();
            MessageBox.Show("Yeni Cari Başarılı Bir Şekilde Eklenmiştir.", "Bilgi");
        }
        void IlListele()
        {
            lookUpEdtIl.Properties.DataSource = (from i in db.Iller
                                                 select new
                                                 {
                                                     i.Id,
                                                     i.Sehir
                                                 }).ToList();
        }
        private void YeniCari_Load(object sender, EventArgs e)
        {
            IlListele();
        }

        private void lookUpEdtIl_EditValueChanged(object sender, EventArgs e)
        {
            int id = int.Parse(lookUpEdtIl.EditValue.ToString());
            lookUpEdtIlce.Properties.DataSource = (from i in db.Ilceler.Where(x => x.Sehir == id)
                                                   select new
                                                   {
                                                       i.Id,
                                                       i.Ilce
                                                   }).ToList();
        }
    }
}
