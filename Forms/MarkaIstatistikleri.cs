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
    public partial class MarkaIstatistikleri : Form
    {
        public MarkaIstatistikleri()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        void Chart1()
        {
            

        }
        void Chart2()
        {

        }
        private void MarkaIstatistikleri_Load(object sender, EventArgs e)
        {
            Chart1();
            Chart2();

            var degerler = db.Urunler.OrderBy(u => u.Marka).GroupBy(u => u.Marka).Select(u => new
            {
                Marka = u.Key,
                Toplam = u.Count()
            });
            gridControl1.DataSource = degerler.ToList();

            //Toplam Ürün Sayısı
            labelControl2.Text = db.Urunler.Count().ToString();

            //Toplam Marka Sayısı
            labelControl3.Text = (from u in db.Urunler
                                  select u.Marka).Distinct().Count().ToString();

            //En Fazla Ürünü Olan Marka
            var marka = (from m in db.Urunler.GroupBy(u => u.Marka)
                         orderby m.Count() descending
                         select new
                         {
                             m.Key
                         }).Select(d => d.Key).FirstOrDefault();
            labelControl5.Text = marka.ToString();

            //En Yüksek Fiyatlı Ürünün Markası
            labelControl7.Text = (from u in db.Urunler
                                  orderby u.SatisFiyat descending
                                  select u.Marka).FirstOrDefault();
        }
    }
}
