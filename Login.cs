using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string kullanici = txtEdtKullanici.Text;
                string sifre = txtEdtSifre.Text;
                var sorgu = from s in db.Admin
                            where s.KullaniciAdi == kullanici && s.Sifre == sifre
                            select s;
                if (sorgu.Any())
                {
                    AnaForm anaForm = new AnaForm();
                    this.Hide();
                    anaForm.Show();
                }
                else
                {
                    XtraMessageBox.Show("Lütfen Girdiğiniz Değerleri Kontrol Ediniz!","UYARI",buttons:MessageBoxButtons.OK,icon:MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lütfen Girdiğiniz Değerleri Kontrol Ediniz!", "UYARI", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
