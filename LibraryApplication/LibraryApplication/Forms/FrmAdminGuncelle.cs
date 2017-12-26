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
    public partial class FrmAdminGuncelle : Form
    {
        public FrmAdminGuncelle()
        {
            InitializeComponent();
        }

        private void FrmAdminGuncelle_Load(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();

            var ad = db.AdminSet.Find(FrmAdminEkrani.ID);

            txtAd.Text = ad.Adi;
            txtAdres.Text = ad.Adres;
            dtDogumTarihi.Value = ad.DogumTarihi;
            txtKullaniciAdi.Text = ad.KullaniciAdi;
            txtMail.Text = ad.Mail;
            txtSifre.Text = ad.Sifre;
            txtSoyad.Text = ad.Soyadi;
            txtTel.Text = ad.Telefon;
            txtUnvan.Text = ad.Unvan;

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();
            var ad = db.AdminSet.Find(FrmAdminEkrani.ID);
            ad.Adi = txtAd.Text;
            ad.Adres = txtAdres.Text;
            ad.DogumTarihi = dtDogumTarihi.Value;
            ad.KullaniciAdi = txtKullaniciAdi.Text;
            ad.Mail = txtMail.Text;
            ad.Sifre = txtSifre.Text;
            ad.Soyadi = txtSoyad.Text;
            ad.Telefon = txtTel.Text;
            ad.Unvan = txtUnvan.Text;

            db.SaveChanges();

            this.Hide();
            MessageBox.Show("Güncelleme işlemi başarı ile gerçekleştirilmiştir.");
            FrmAdminEkrani frm = new FrmAdminEkrani();
            frm.Show();
        }
    }
}
