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
    public partial class Mesajlar : Form
    {
        public Mesajlar()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void Mesajlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.Mesajlar.ToList();

            //Toplam Mesaj Sayısı
            labelControl2.Text = db.Mesajlar.Count().ToString();

            //Teşekkür Mesajı Sayısı
            labelControl3.Text = db.Mesajlar.Where(x => x.Konu == "Teşekkür").Count().ToString();

            //Şikayet Mesaj Sayısı
            labelControl5.Text = db.Mesajlar.Where(x => x.Konu == "Şikayet").Count().ToString();

            //Rica Mesaj Sayısı
            labelControl7.Text = db.Mesajlar.Where(x => x.Konu == "Rica").Count().ToString();

            //En Çok Mesaj Konusu
            var konu = (from m in db.Mesajlar.GroupBy(x => x.Konu)
                        orderby m.Count() descending
                        select new
                        {
                            m.Key
                        }).Select(x => x.Key).ToList().FirstOrDefault();
            labelControl9.Text = konu.ToString();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (Application.OpenForms["Mail"] == null)
            {
                Forms.Mail mail = new Mail();
                mail.alici = gridView1.GetFocusedRowCellValue("Mail").ToString();
                mail.StartPosition = FormStartPosition.CenterScreen;
                mail.Show();
            }
        }
    }
}
