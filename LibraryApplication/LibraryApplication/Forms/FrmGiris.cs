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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKullaniciEkle frm = new FrmKullaniciEkle();
            frm.ShowDialog();
        }

        public static int ID = 0;

        string ceza = "";

        DateTime bitistarihi = DateTime.Now;

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();

            if (db.KullaniciSet.Count() > 0 || db.AdminSet.Count() > 0)
            {

                if (kullanicisorgusu(txtKullaniciAdi.Text, txtSifre.Text, out ID, out ceza, out bitistarihi))
                {
                    FrmKullaniciEkrani frm = new FrmKullaniciEkrani();
                    frm.Show();
                    this.Hide();
                }
                else if (adminsorgusu(txtKullaniciAdi.Text, txtSifre.Text, out ID))
                {
                    FrmAdminEkrani frm = new FrmAdminEkrani();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    if (ceza == "cezalı")
                    {
                        MessageBox.Show("Maksimum ceza sayısına ulaştığınız için kütüphanemizden yararlanma hakkınız kaybetmiş bulunmaktasınız", "BİLGİ");
                        textbozTemizle();
                    }
                    else if (ceza == "tarihcezası")
                    {
                        MessageBox.Show(bitistarihi + " tarihinene kadar cezanız bulunmaktadır.Bu süre zarfında kütüphanemizden yararlanmanız yasaklanmıştır.");
                        textbozTemizle();
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kullanıcı veya admin bulunamamıştır, Lütfen Kayıt Olunuz");
                    }
                }
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
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

        private bool adminsorgusu(string KullaniciAdi, string Sifre, out int ID)
        {
            ModelDBContainer db = new ModelDBContainer();
            ID = -1;
            var sorgu = from a in db.AdminSet
                        where a.KullaniciAdi == KullaniciAdi && a.Sifre == Sifre
                        select new
                        {
                            a.Id,
                        };
            if (sorgu.Any())
            {
                ID = sorgu.FirstOrDefault().Id;
                return true;

            }
            else
            {
                return false;
            }
        }

        private bool kullanicisorgusu(string KullaniciAdi, string Sifre, out int ID, out string ceza, out DateTime bitistarihi)
        {
            ModelDBContainer db = new ModelDBContainer();
            ID = -1;
            ceza = "";
            bitistarihi = DateTime.Now;
            var sorgu = from k in db.KullaniciSet
                        where k.KullaniciAdi == KullaniciAdi && k.Sifre == Sifre
                        select new
                        {
                            k.Id,
                        };

            if (sorgu.Count()>0)
            {
                Kullanici klnc = db.KullaniciSet.Find(sorgu.FirstOrDefault().Id);
                if (sorgu.Any())
                {
                    if (klnc.CezaSayisi >= 5)
                    {
                        ceza = "cezalı";
                        return false;
                    }
                    else if (klnc.CezaBitisTarihi > DateTime.Now)
                    {
                        ceza = "tarihcezası";
                        bitistarihi = klnc.CezaBitisTarihi.Value;
                        return false;
                    }
                    else
                    {
                        ID = sorgu.FirstOrDefault().Id;
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }


        }

        void textbozTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
        }
    }
}
