using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApplication.Forms
{
    public partial class FrmKullaniciEkle : Form
    {
        public FrmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Year - dtDogumTarihi.Value.Year >= 12)
            {
                ModelDBContainer db = new ModelDBContainer();
                Kullanici klnc = new Kullanici();
                klnc.TCKimlikNo = txtKimlikNo.Text;
                klnc.Adi = txtAd.Text;
                klnc.Soyadi = txtSoyad.Text;
                klnc.Adres = txtAdres.Text;
                klnc.CezaDurumu = false;
                klnc.DogumTarihi = dtDogumTarihi.Value;
                klnc.KullaniciAdi = txtKullaniciAdi.Text;
                klnc.Mail = txtMail.Text;
                klnc.Sifre = txtSifre.Text;
                klnc.Telefon = txtTel.Text;
                klnc.Unvan = txtUnvan.Text;

                db.KullaniciSet.Add(klnc);
                db.SaveChanges();

                MessageBox.Show("Kaydınız Oluşturulmuştur, Lütfen Giriş Yapınız");

                this.Close();
            }
            else
            {
                MessageBox.Show("12 Yaşından Küçükler Kütüphanemize Üye Olamaz", "Bilgi");
                this.Close();
            }
        }

        private void FrmKullaniciEkle_Load(object sender, EventArgs e)
        {
            if (ckhGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void ckhGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (ckhGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }
    }
}
