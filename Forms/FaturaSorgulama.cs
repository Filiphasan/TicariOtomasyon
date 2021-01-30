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
    public partial class FaturaSorgulama : Form
    {
        public FaturaSorgulama()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtEdtFaturaId.Text != "")
            {
                int id = int.Parse(txtEdtFaturaId.Text);

                var kalemler = (from k in db.FaturaDetay
                                select new
                                {
                                    k.FaturaDetayId,
                                    k.FaturaId,
                                    k.FaturaBilgi.SıraNo,
                                    k.Urun,
                                    k.Adet,
                                    k.Fiyat,
                                    k.Tutar
                                }).Where(x => x.FaturaId == id);
                gridControl1.DataSource = kalemler.ToList();
            }
            else
            {
                MessageBox.Show("Lütfen FaturaId Kısmını Boş Bırakmayın!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
