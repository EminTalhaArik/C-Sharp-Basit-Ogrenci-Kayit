using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayıt
{
    public partial class Form1 : Form
    {
        string girilenTCNo = "";
        string girilenAd = "";
        string secilenBolum = "";
        string secilenCinsiyet = "";

        List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        int seciliOgrenciIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (seciliOgrenciIndex > 0)
            {
                OgrenciBul(Ogrenciler[seciliOgrenciIndex - 1].TCNo);
            }
            else
            {
                MessageBox.Show("Daha Fazla Öğrenci Bulunamamaktadır!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (seciliOgrenciIndex < Ogrenciler.Count - 1)
            {
                OgrenciBul(Ogrenciler[seciliOgrenciIndex + 1].TCNo);
            }
            else
            {
                MessageBox.Show("Daha Fazla Öğrenci Bulunamamaktadır!");
            }
        }

        private void btnOgrenciAra_Click(object sender, EventArgs e)
        {
            try
            {
                girilenTCNo = Convert.ToInt64(txtTCno.Text).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Doğru Formatlarda Giriş Yapınız!");
                return;
            }

            if (TCNoKontrol(girilenTCNo))
            {
                OgrenciBul(girilenTCNo);
            }
        }

        private void OgrenciBul(string tcNo)
        {
            foreach (Ogrenci item in Ogrenciler)
            {
                if (item.TCNo == tcNo)
                {
                    lblAdSoyad.Text = item.AdSoyad;
                    lblBolum.Text = item.Bolum;
                    lblCinsiyet.Text = item.Cinsiyet;
                    lblTCno.Text = item.TCNo;

                    seciliOgrenciIndex = Ogrenciler.IndexOf(item);
                    MessageBox.Show("Öğrenci Başarı İle Getirildi!");

                    break;
                }
            }
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            try
            {
                girilenTCNo = Convert.ToInt64(txtTCno.Text).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Doğru Formatlarda Giriş Yapınız!");
                return;
            }

            if (TCNoKontrol(girilenTCNo))
            {
                OgrenciSil(girilenTCNo);

                txtAdSoyad.Text = "";
                txtTCno.Text = "";
                rButonErkek.Checked = false;
                rButonKiz.Checked = false;
                cBoxBolum.SelectedItem = null;
            }
        }

        private void OgrenciSil(string tcNo)
        {
            foreach (var item in Ogrenciler)
            {
                if (item.TCNo == tcNo)
                {
                    Ogrenciler.Remove(item);

                    txtAdSoyad.Text = "";
                    txtTCno.Text = "";
                    rButonErkek.Checked = false;
                    rButonKiz.Checked = false;
                    cBoxBolum.SelectedItem = null;

                    lblAdSoyad.Text = "";
                    lblBolum.Text = "";
                    lblCinsiyet.Text = "";
                    lblOgrSayisi.Text = Ogrenciler.Count.ToString();
                    lblTCno.Text = "";

                    MessageBox.Show("Öğrenci Başarı İle Silindi!");
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                girilenTCNo = Convert.ToInt64(txtTCno.Text).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Doğru Formatlarda Giriş Yapınız!");
                return;
            }

            girilenAd = txtAdSoyad.Text;
            secilenBolum = cBoxBolum.Text;

            if (TCNoKontrol(girilenTCNo) && CinsiyetKontrol(secilenCinsiyet) && AdKontrol(girilenAd) && BolumKontrol(secilenBolum))
            {
                OgrenciEkle(girilenTCNo, girilenAd, secilenBolum, secilenCinsiyet);
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
            }
        }

        private void OgrenciEkle(string tcNo, string ad, string bolum, string cinsiyet)
        {
            if (!OgrenciVarMi(tcNo))
            {
                Ogrenciler.Add(new Ogrenci
                {
                    TCNo = tcNo,
                    AdSoyad = ad,
                    Bolum = bolum,
                    Cinsiyet = cinsiyet
                });

                txtAdSoyad.Text = "";
                txtTCno.Text = "";
                rButonErkek.Checked = false;
                rButonKiz.Checked = false;
                cBoxBolum.SelectedItem = null;

                lblOgrSayisi.Text = Ogrenciler.Count.ToString();
                MessageBox.Show("Öğrenci Başarı İle Eklenmiştir.");
            }
            else
            {
                MessageBox.Show("Eklemeye Çalıştığınız Öğrenci Sistemde Kayıtlıdır!");
            }
        }

        private bool OgrenciVarMi(string tcNo)
        {
            foreach (var item in Ogrenciler)
            {
                if (item.TCNo == tcNo)
                {
                    return true;
                }
            }
            return false;
        }

        private bool TCNoKontrol(string tcNo)
        {
            if (!string.IsNullOrEmpty(tcNo) && tcNo.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CinsiyetKontrol(string cinsiyet)
        {
            if (!string.IsNullOrEmpty(cinsiyet))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool BolumKontrol(string bolum)
        {
            if (!string.IsNullOrEmpty(bolum))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool AdKontrol(string ad)
        {
            if (!string.IsNullOrEmpty(ad))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void rButonCinsiyet_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rButton = (RadioButton)sender;
            secilenCinsiyet = rButton.Text;
        }

        public class Ogrenci
        {
            public string TCNo;
            public string AdSoyad;
            public string Bolum;
            public string Cinsiyet;
        }
    }
}
