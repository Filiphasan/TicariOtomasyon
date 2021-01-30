using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TeknikServisOtomasyon.Forms
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }
        internal string alici;
        private void Mail_Load(object sender, EventArgs e)
        {
            if (alici != null)
            {
                txtEdtAlici.Text = alici;
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                string fromMail = "hasaerda@gmail.com";
                string sifre = "filip483706";
                string alici = txtEdtAlici.Text;
                string konu = txtEdtKonu.Text;
                string icerik = rchTxtIcerik.Text;
                mail.From = new MailAddress(fromMail);
                mail.To.Add(alici);
                mail.Subject = konu;
                mail.Body = icerik;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromMail, sifre);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Mail Başarılı Bir Şekilde Gönderilmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata, Lütfen Değerleri Kontrol Ediniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
