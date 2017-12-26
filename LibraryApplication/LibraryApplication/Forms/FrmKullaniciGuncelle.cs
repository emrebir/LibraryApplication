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
    public partial class FrmKullaniciGuncelle : Form
    {
        public FrmKullaniciGuncelle()
        {
            InitializeComponent();
        }

        private void FrmKullaniciGuncelle_Load(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();
            var klnc = db.KullaniciSet.Find(FrmGiris.ID);
            txtAd.Text = klnc.Adi;
            txtKimlikNo.Text = klnc.TCKimlikNo;
            txtAdres.Text = klnc.Adres;
            txtKullaniciAdi.Text = klnc.KullaniciAdi;
            txtMail.Text = klnc.Mail;
            txtSifre.Text = klnc.Sifre;
            txtSoyad.Text = klnc.Soyadi;
            txtTel.Text = klnc.Telefon;
            txtUnvan.Text = klnc.Unvan;
            dtDogumTarihi.Value = klnc.DogumTarihi;
            

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
            var klnc = db.KullaniciSet.Find(FrmGiris.ID);
            klnc.Adi = txtAd.Text;
            klnc.TCKimlikNo = txtKimlikNo.Text;
            klnc.Adres = txtAdres.Text;
            klnc.DogumTarihi = dtDogumTarihi.Value;
            klnc.KullaniciAdi = txtKullaniciAdi.Text;
            klnc.Mail = txtMail.Text;
            klnc.Sifre = txtSifre.Text;
            klnc.Soyadi = txtSoyad.Text;
            klnc.Telefon = txtTel.Text;
            klnc.Unvan = txtUnvan.Text;

            db.SaveChanges();

            this.Hide();
            FrmKullaniciEkrani frm = new FrmKullaniciEkrani();
            frm.Show();
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
