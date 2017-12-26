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
    public partial class FrmKullaniciEkrani : Form
    {
        public FrmKullaniciEkrani()
        {
            InitializeComponent();
        }

        private void FrmKullaniciEkrani_Load(object sender, EventArgs e)
        {
            if (FrmGiris.ID != -1)
            {
                ModelDBContainer db = new ModelDBContainer();
                var klnc = db.KullaniciSet.Find(FrmGiris.ID);
                tslblKullaniciAdi.Text = "Hoşgeldiniz " + klnc.Unvan + " " + klnc.Adi + " " + klnc.Soyadi;
            }
        }

        private void tsBtnCikisYap_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Oturumunuz sonlandırılmıştır.", "Bilgi");
            FrmGiris frm = new FrmGiris();
            frm.Show();
        }

        private void tsBtnHesapAyarlari_Click(object sender, EventArgs e)
        {
            FrmKullaniciGuncelle frm = new FrmKullaniciGuncelle();
            this.Hide();
            frm.Show();
        }
    }
}
