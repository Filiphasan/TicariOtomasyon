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
    public partial class Hakkimizda : Form
    {
        public Hakkimizda()
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
            if (rchTxtIcerik.Text.Length <= 500)
            {
                var deger = db.Hakkimizda.Find(1);
                deger.Hakkimizda1 = rchTxtIcerik.Text;
                db.SaveChanges();
                MessageBox.Show("Hakkımızda yazısı başarılı bir şekilde güncellenmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen 500 karekter sınırını geçmeyin!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
