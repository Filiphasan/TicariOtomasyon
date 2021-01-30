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
    public partial class Rehber : Form
    {
        public Rehber()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void Rehber_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from c in db.Cariler
                                       select new
                                       {
                                           Musteri = c.Ad + " " + c.Soyad,
                                           c.Telefon,
                                           c.Mail
                                       }).ToList();
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
