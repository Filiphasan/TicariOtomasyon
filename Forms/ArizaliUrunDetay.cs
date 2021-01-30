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
    public partial class ArizaliUrunDetay : Form
    {
        public ArizaliUrunDetay()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void ArizaliUrunDetay_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.UrunTakip
                           select new
                           {
                               u.TakipId,
                               u.SeriNo,
                               u.Tarih,
                               u.Aciklama
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
