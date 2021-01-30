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
using TeknikServisOtomasyon.Forms;

namespace TeknikServisOtomasyon
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["UrunListesi"] == null)
            {
                Forms.UrunListesi urunListesi = new Forms.UrunListesi();
                urunListesi.MdiParent = this;
                urunListesi.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["YeniUrun"] == null)
            {
                Forms.YeniUrun yeniUrun = new Forms.YeniUrun();
                yeniUrun.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["KategoriListesi"] == null)
            {
                Forms.KategoriListesi kategoriListesi = new Forms.KategoriListesi();
                kategoriListesi.MdiParent = this;
                kategoriListesi.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["YeniKategori"] == null)
            {
                Forms.YeniKategori yeniKategori = new Forms.YeniKategori();
                yeniKategori.Show();
            }
        }

        private void barBtnUrunIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["UrunIstatistikleri"] == null)
            {
                Forms.UrunIstatistikleri urunIstatistikleri = new Forms.UrunIstatistikleri();
                urunIstatistikleri.MdiParent = this;
                urunIstatistikleri.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["MarkaIstatistikleri"] == null)
            {
                Forms.MarkaIstatistikleri markaIstatistikleri = new Forms.MarkaIstatistikleri();
                markaIstatistikleri.MdiParent = this;
                markaIstatistikleri.Show();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["CariListesi"] == null)
            {
                Forms.CariListesi cariListesi = new Forms.CariListesi();
                cariListesi.MdiParent = this;
                cariListesi.Show();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["CariIlIstatistik"] == null)
            {
                Forms.CariIlIstatistik cariIlIstatistik = new Forms.CariIlIstatistik();
                cariIlIstatistik.MdiParent = this;
                cariIlIstatistik.Show();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["YeniCari"] == null)
            {
                Forms.YeniCari yeniCari = new Forms.YeniCari();
                yeniCari.StartPosition = FormStartPosition.CenterScreen;
                yeniCari.Show();
            }
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["DepartmanListesi"] == null)
            {
                Forms.DepartmanListesi departmanListesi = new Forms.DepartmanListesi();
                departmanListesi.MdiParent = this;
                departmanListesi.Show();
            }
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["YeniDepartman"] == null)
            {
                Forms.YeniDepartman yeniDepartman = new Forms.YeniDepartman();
                yeniDepartman.StartPosition = FormStartPosition.CenterScreen;
                yeniDepartman.Show();
            }
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["PersonelListesi"] == null)
            {
                Forms.PersonelListesi personelListesi = new Forms.PersonelListesi();
                personelListesi.MdiParent = this;
                personelListesi.Show();
            }
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["DovizKurları"] == null)
            {
                Forms.DovizKurları dovizKurları = new Forms.DovizKurları();
                dovizKurları.MdiParent = this;
                dovizKurları.Show();
            }
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["NotListesi"] == null)
            {
                Forms.NotListesi notListesi = new Forms.NotListesi();
                notListesi.MdiParent = this;
                notListesi.Show();
            }
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["YeniNot"] == null)
            {
                Forms.YeniNot yeniNot = new Forms.YeniNot();
                yeniNot.StartPosition = FormStartPosition.CenterScreen;
                yeniNot.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["ArizaliUrunListesi"] == null)
            {
                Forms.ArizaliUrunListesi listesi = new Forms.ArizaliUrunListesi();
                listesi.MdiParent = this;
                listesi.Show();
            }
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["YeniSatis"] == null)
            {
                Forms.YeniSatis yeniSatis = new Forms.YeniSatis();
                yeniSatis.StartPosition = FormStartPosition.CenterScreen;
                yeniSatis.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["SatisListesi"] == null)
            {
                Forms.SatisListesi satisListesi = new Forms.SatisListesi();
                satisListesi.MdiParent = this;
                satisListesi.Show();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["SatisListesi"] == null)
            {
                Forms.SatisListesi satisListesi = new Forms.SatisListesi();
                satisListesi.MdiParent = this;
                satisListesi.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["ArizaliUrunKaydı"] == null)
            {
                Forms.ArizaliUrunKaydı arizaliUrunKaydı = new Forms.ArizaliUrunKaydı();
                arizaliUrunKaydı.StartPosition = FormStartPosition.CenterScreen;
                arizaliUrunKaydı.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["ArizaliUrunAciklama"] == null)
            {
                Forms.ArizaliUrunAciklama aciklama = new Forms.ArizaliUrunAciklama();
                aciklama.StartPosition = FormStartPosition.CenterScreen;
                aciklama.Show();
            }
        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["ArizaliUrunDetay"] == null)
            {
                Forms.ArizaliUrunDetay detay = new Forms.ArizaliUrunDetay();
                detay.MdiParent = this;
                detay.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["QrCode"] == null)
            {
                Forms.QrCode qrCode = new Forms.QrCode();
                qrCode.StartPosition = FormStartPosition.CenterScreen;
                qrCode.Show();
            }
        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FaturaListesi"] == null)
            {
                Forms.FaturaListesi listesi = new Forms.FaturaListesi();
                listesi.MdiParent = this;
                listesi.Show();
            }
        }

        void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FaturaKalemi"] == null)
            {
                Forms.FaturaKalemi faturaKalemi = new Forms.FaturaKalemi();
                faturaKalemi.MdiParent = this;
                faturaKalemi.Show();
            }
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FaturaSorgulama"] == null)
            {
                Forms.FaturaSorgulama sorgulama = new FaturaSorgulama();
                sorgulama.MdiParent = this;
                sorgulama.Show();
            }
        }

        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Hakkimizda"] == null)
            {
                Forms.Hakkimizda hakkimizda = new Forms.Hakkimizda();
                hakkimizda.StartPosition = FormStartPosition.CenterScreen;
                hakkimizda.Show();
            }
        }

        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Raporlar"] == null)
            {
                Forms.Raporlar raporlar = new Forms.Raporlar();
                raporlar.WindowState = FormWindowState.Maximized;
                raporlar.Show();
            }
        }

        private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["AnaSayfa"] == null)
            {
                Forms.AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.MdiParent = this;
                anaSayfa.Show();
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (Application.OpenForms["AnaSayfa"] == null)
            {
                Forms.AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.MdiParent = this;
                anaSayfa.Show();
            }
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Rehber"] == null)
            {
                Forms.Rehber rehber = new Rehber();
                rehber.MdiParent = this;
                rehber.Show();
            }
        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Mesajlar"] == null)
            {
                Forms.Mesajlar mesajlar = new Forms.Mesajlar();
                mesajlar.MdiParent = this;
                mesajlar.Show();
            }
        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Mail"] == null)
            {
                Forms.Mail mail = new Mail();
                mail.StartPosition = FormStartPosition.CenterScreen;
                mail.Show();
            }
        }

        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }
    }
}
