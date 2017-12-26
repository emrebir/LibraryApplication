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
    public partial class FrmAdminEkle : Form
    {
        public FrmAdminEkle()
        {
            InitializeComponent();
        }

        private void FrmAdminEkle_Load(object sender, EventArgs e)
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();

            Admin ad = new Admin();

            ad.Adi = txtAd.Text;
            ad.Adres = txtAdres.Text;
            ad.DogumTarihi = dtDogumTarihi.Value;
            ad.KullaniciAdi = txtKullaniciAdi.Text;
            ad.Mail = txtMail.Text;
            ad.Sifre = txtSifre.Text;
            ad.Soyadi = txtSoyad.Text;
            ad.Telefon = txtTel.Text;
            ad.Unvan = txtUnvan.Text;

            db.AdminSet.Add(ad);
            db.SaveChanges();

            MessageBox.Show("Kaydınız oluşturulmuştur.");
            this.Close();
            FrmAdminEkrani frm = new FrmAdminEkrani();
            frm.Show();
        }
    }
}
