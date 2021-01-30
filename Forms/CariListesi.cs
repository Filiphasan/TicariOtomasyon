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
    public partial class CariListesi : Form
    {
        public CariListesi()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        void Temizle()
        {
            txtEdtAd.Text = "";
            txtEdtAdres.Text = "";
            txtEdtBanka.Text = "";
            txtEdtCariId.Text = "";
            txtEdtSoyad.Text = "";
            txtEdtStatü.Text = "";
            txtEdtTelefon.Text = "";
            txtEdtVergiDairesi.Text = "";
            txtEdtVergiNo.Text = "";
            lookUpEdtIl.Text = "";
            lookUpEdtIlce.Text = "";
        }
        void Listele()
        {
            var cariler = from c in db.Cariler
                          select new
                          {
                              c.Id,
                              c.Ad,
                              c.Soyad,
                              c.Telefon,
                              c.Il,
                              c.Ilce,
                              c.Banka,
                              c.VergiDairesi,
                              c.VergiNo,
                              c.Statü,
                              c.Adres
                          };
            gridControl1.DataSource = cariler.ToList();
        }
        private void smplBtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        void IlListele()
        {
            var iller = (from i in db.Iller
                         select new
                         {
                             i.Id,
                             i.Sehir
                         }).ToList();
            lookUpEdtIl.Properties.DataSource = iller;
        }

        private void CariListesi_Load(object sender, EventArgs e)
        {
            IlListele();
            Listele();
            //Toplam Cari Sayısı
            labelControl12.Text = db.Cariler.Count().ToString();

            //Toplam İl Sayısı
            labelControl14.Text = (from c in db.Cariler
                                   select c.Il).Distinct().Count().ToString();

            //En Fazla Cari Bulunan İl
            var deger = (from c in db.Cariler.GroupBy(x => x.Il)
                         orderby c.Count() descending
                         select new
                         {
                             c.Key
                         }).Select(x => x.Key).FirstOrDefault();
            labelControl16.Text = deger.ToString();

            //Aktif Cari Sayısı
            labelControl18.Text = db.UrunHareket.GroupBy(c => c.Musteri).Count().ToString();
        }

        private void lookUpEdtIl_EditValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lookUpEdtIl.EditValue);
            lookUpEdtIlce.Properties.DataSource = (from i in db.Ilceler.Where(x => x.Sehir == id)
                                                   select new
                                                   {
                                                       i.Id,
                                                       i.Ilce
                                                   }
                                                   ).ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Temizle();
            txtEdtCariId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtEdtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtEdtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            if (gridView1.GetFocusedRowCellValue("Telefon") != null)
            {
                txtEdtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("Il") != null)
            {
                lookUpEdtIl.Text = gridView1.GetFocusedRowCellValue("Il").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("Ilce") != null)
            {
                lookUpEdtIlce.Text = gridView1.GetFocusedRowCellValue("Ilce").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("Banka") != null)
            {
                txtEdtBanka.Text = gridView1.GetFocusedRowCellValue("Banka").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("VergiDairesi") != null)
            {
                txtEdtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VergiDairesi").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("VergiNo") != null)
            {
                txtEdtVergiNo.Text = gridView1.GetFocusedRowCellValue("VergiNo").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("Statü") != null)
            {
                txtEdtStatü.Text = gridView1.GetFocusedRowCellValue("Statü").ToString();
            }
            if (gridView1.GetFocusedRowCellValue("Adres") != null)
            {
                txtEdtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            }
        }

        private void smplBtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Cariyi Gerçekten Silmek İstiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtEdtCariId.Text != "")
                {
                    int id = int.Parse(txtEdtCariId.Text);
                    var cari = db.Cariler.Find(id);
                    db.Cariler.Remove(cari);
                    db.SaveChanges();
                    MessageBox.Show("Seçili Cari Başarılı Bir Şekilde Silinmiştir.", "BİLGİ");
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Cari Seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void smpBtnKaydet_Click(object sender, EventArgs e)
        {
            Cariler cari = new Cariler();
            cari.Ad = txtEdtAd.Text;
            cari.Soyad = txtEdtSoyad.Text;
            cari.Il = lookUpEdtIl.Text;
            cari.Ilce = lookUpEdtIlce.Text;
            db.Cariler.Add(cari);
            db.SaveChanges();
            MessageBox.Show("Yeni Cari Sisteme Başarılı Bir Şekilde Eklenmiştir.","BİLGİ");
        }
    }
}
