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
    public partial class PersonelListesi : Form
    {
        public PersonelListesi()
        {
            InitializeComponent();
        }
        DevExTeknikServisEntities db = new DevExTeknikServisEntities();
        void Listele()
        {
            var personeller = from p in db.Personeller
                              select new
                              {
                                  p.Id,
                                  p.Ad,
                                  p.Soyad,
                                  Departman = p.Departmanlar.Ad,
                                  p.Fotograf,
                                  p.Mail,
                                  p.Telefon
                              };
            gridControl1.DataSource = personeller.ToList();
        }
        void Temizle()
        {
            txtEdtPersonelId.Text = "";
            txtEdtAd.Text = "";
            txtEdtSoyad.Text = "";
            txtEdtMail.Text = "";
            txtEdtFotograf.Text = "";
            txtEdtTelefon.Text = "";
        }
        private void PersonelListesi_Load(object sender, EventArgs e)
        {
            Listele();

            var departmanlar = from d in db.Departmanlar
                               select new
                               {
                                   d.Id,
                                   d.Ad
                               };
            lookUpEdtDepartman.Properties.DataSource = departmanlar.ToList();
        }

        private void smplBtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtEdtPersonelId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtEdtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtEdtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            if (gridView1.GetFocusedRowCellValue("Fotograf") != null)
            {
                txtEdtFotograf.Text = gridView1.GetFocusedRowCellValue("Fotograf").ToString();
            }
            else
            {
                txtEdtFotograf.Text = "";
            }

            if (gridView1.GetFocusedRowCellValue("Mail") != null)
            {
                txtEdtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            }
            else
            {
                txtEdtMail.Text = "";
            }

            if (gridView1.GetFocusedRowCellValue("Telefon") != null)
            {
                txtEdtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            }
            else
            {
                txtEdtTelefon.Text = "";
            }

        }

        private void smpBtnKaydet_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Ad = txtEdtAd.Text;
            personeller.Soyad = txtEdtSoyad.Text;
            personeller.Departman = byte.Parse(lookUpEdtDepartman.EditValue.ToString());
            if (txtEdtFotograf.Text != "")
            {
                personeller.Fotograf = txtEdtFotograf.Text;
            }
            else
            {
                personeller.Fotograf = "";
            }

            if (txtEdtMail.Text != "")
            {
                personeller.Mail = txtEdtMail.Text;
            }
            else
            {
                personeller.Mail = "";
            }

            if (txtEdtTelefon.Text != "")
            {
                personeller.Telefon = txtEdtTelefon.Text;
            }
            else
            {
                personeller.Telefon = "";
            }
            db.Personeller.Add(personeller);
            db.SaveChanges();
            MessageBox.Show("Yeni Personel Başarılı Bir Şekilde Eklenmiştir.", "Bilgi");
            Temizle();
            Listele();

        }

        private void smplBtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Personeli Gerçekten Silmek İstiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (txtEdtPersonelId.Text != "")
                {
                    int id = int.Parse(txtEdtPersonelId.Text);
                    var personel = db.Personeller.Find(id);
                    db.Personeller.Remove(personel);
                    db.SaveChanges();
                    MessageBox.Show("Personel Başarılı Bir Şekilde Silinmiştir.", "UYARI");
                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Lütfen Personel Seçiniz!");
                }
            }
        }

        private void smplBtnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtEdtPersonelId.Text != "")
            {
                int id = int.Parse(txtEdtPersonelId.Text);
                var personel = db.Personeller.Find(id);
                personel.Ad = txtEdtAd.Text;
                personel.Soyad = txtEdtSoyad.Text;
                personel.Departman = byte.Parse(lookUpEdtDepartman.EditValue.ToString());
                if (txtEdtFotograf.Text != "")
                {
                    personel.Fotograf = txtEdtFotograf.Text;
                }
                else
                {
                    personel.Fotograf = "";
                }

                if (txtEdtMail.Text != "")
                {
                    personel.Mail = txtEdtMail.Text;
                }
                else
                {
                    personel.Mail = "";
                }

                if (txtEdtTelefon.Text != "")
                {
                    personel.Telefon = txtEdtTelefon.Text;
                }
                else
                {
                    personel.Telefon = "";
                }
                db.SaveChanges();
                MessageBox.Show("Personel Bilgileri Başarılı Bir Şekilde Güncellenmiştir.", "BİLGİ");

                Listele(); Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Personel Seçimi Yapınız!");
            }
        }
    }
}
