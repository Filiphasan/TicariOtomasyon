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
    public partial class CariIlIstatistik : Form
    {
        public CariIlIstatistik()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void CariIlIstatistik_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.Cariler.
                OrderBy(c => c.Il).
                GroupBy(c => c.Il).
                Select(z => new { İL = z.Key, TOPLAM = z.Count() }).ToList();

        }
    }
}
