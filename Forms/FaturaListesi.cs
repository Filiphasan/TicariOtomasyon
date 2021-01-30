using DevExpress.Utils.StructuredStorage.Internal.Reader;
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
    public partial class FaturaListesi : Form
    {
        public FaturaListesi()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        void Listele()
        {
            var faturalar = from f in db.FaturaBilgi
                            select new
                            {
                                f.Id,
                                f.Seri,
                                f.SıraNo,
                                f.Tarih,
                                f.Saat,
                                f.VergiDaire,
                                Cari = f.Cariler.Ad + " " + f.Cariler.Soyad,
                                Personel = f.Personeller.Ad + " " + f.Personeller.Soyad
                            };
            gridControl1.DataSource = faturalar.ToList();
        }
        void ListeleCari()
        {
            var cariler = from c in db.Cariler
                          select new
                          {
                              c.Id,
                              Cari = c.Ad + " " + c.Soyad
                          };
            lookUpEdtCari.Properties.DataSource = cariler.ToList();
        }
        void ListelePersonel()
        {
            var personeller = from p in db.Personeller
                              select new
                              {
                                  p.Id,
                                  Personel = p.Ad + " " + p.Soyad
                              };
            lookUpEdtPersonel.Properties.DataSource = personeller.ToList();
        }
        void Temizle()
        {
            txtEdtFaturaId.Text = "";
            txtEdtSeriNo.Text = "";
            txtEdtSiraNo.Text = "";
            txtEdtTarih.Text = "";
            txtEdtSaat.Text = "";
            txtEdtVergiDaire.Text = "";
        }
        private void FaturaListesi_Load(object sender, EventArgs e)
        {
            Listele();
            ListeleCari();
            ListelePersonel();
        }

        private void smplBtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void smpBtnKaydet_Click(object sender, EventArgs e)
        {
            FaturaBilgi fatura = new FaturaBilgi();
            fatura.Seri = txtEdtSeriNo.Text;
            fatura.SıraNo = txtEdtSiraNo.Text;
            fatura.Tarih = DateTime.Parse(txtEdtTarih.Text);
            fatura.Saat = txtEdtSaat.Text;
            fatura.VergiDaire = txtEdtVergiDaire.Text;
            fatura.Cari = int.Parse(lookUpEdtCari.EditValue.ToString());
            fatura.Personel = short.Parse(lookUpEdtPersonel.EditValue.ToString());
            db.FaturaBilgi.Add(fatura);
            db.SaveChanges();
            MessageBox.Show("Yeni Fatura Başarılı Bir Şekilde Sisteme Eklenmiştir.", "BİLGİ");
            Listele();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtFaturaId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtEdtSeriNo.Text = gridView1.GetFocusedRowCellValue("Seri").ToString();
            txtEdtSiraNo.Text = gridView1.GetFocusedRowCellValue("SıraNo").ToString();
            txtEdtTarih.Text = gridView1.GetFocusedRowCellValue("Tarih").ToString();
            txtEdtSaat.Text = gridView1.GetFocusedRowCellValue("Saat").ToString();
            txtEdtVergiDaire.Text = gridView1.GetFocusedRowCellValue("VergiDaire").ToString();
            lookUpEdtCari.Text = gridView1.GetFocusedRowCellValue("Cari").ToString();
            lookUpEdtPersonel.Text = gridView1.GetFocusedRowCellValue("Personel").ToString();
        }

        private void smplBtnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtEdtFaturaId.Text != "")
            {
                int id = int.Parse(txtEdtFaturaId.Text);
                var fatura = db.FaturaBilgi.Find(id);
                fatura.Seri = txtEdtSeriNo.Text;
                fatura.SıraNo = txtEdtSiraNo.Text;
                fatura.Tarih = DateTime.Parse(txtEdtTarih.Text);
                fatura.Saat = txtEdtSaat.Text;
                fatura.VergiDaire = txtEdtVergiDaire.Text;
                fatura.Cari = int.Parse(lookUpEdtCari.EditValue.ToString());
                fatura.Personel = short.Parse(lookUpEdtPersonel.EditValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Seçili Fatura Bilgileri Başarılı Bir Şekilde Güncellenmiştir.", "BİLGİ");
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Fatura Seçiniz!", "UYARI");
            }
        }

        private void smplBtnSil_Click(object sender, EventArgs e)
        {
            //if (txtEdtFaturaId.Text != "")
            //{
            //    int id = int.Parse(txtEdtFaturaId.Text);
            //    var fatura = db.FaturaBilgi.Find(id);
            //    db.FaturaBilgi.Remove(fatura);
            //    db.SaveChanges();
            //    MessageBox.Show("Seçili Fatura Başarılı Bir Şekilde Silinmiştir.","");
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen Bir Fatura Seçiniz!", "UYARI");
            //}
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Forms.FaturaCıktı cıktı = new FaturaCıktı();
            cıktı.StartPosition = FormStartPosition.CenterScreen;
            cıktı.id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            cıktı.Show();
        }
    }
}
