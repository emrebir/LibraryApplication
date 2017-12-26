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
    public partial class FrmAdminEkrani : Form
    {
        public static int ID;

        public FrmAdminEkrani()
        {
            InitializeComponent();
        }

        private void FrmAdminEkrani_Load(object sender, EventArgs e)
        {
            if (FrmGiris.ID != -1)
            {
                ModelDBContainer db = new ModelDBContainer();
                var ad = db.AdminSet.Find(FrmGiris.ID);
                tslblKullaniciAdi.Text = "Hoşgeldiniz " + ad.Unvan + " " + ad.Adi + " " + ad.Soyadi;
            }
        }

        private void tsbtnCikisYap_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Oturumunuz sonlandırılmıştır.", "Bilgi");
            FrmGiris frm = new FrmGiris();
            frm.Show();
        }

        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminEkle frm = new FrmAdminEkle();
            frm.Show();
        }

        private void tsBtnAdminler_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();

            var sorgu = (from a in db.AdminSet
                         select new
                         {
                             a.Id,
                             a.Unvan,
                             a.Adi,
                             a.Soyadi,
                             a.DogumTarihi,
                             a.Mail,
                             a.Telefon,
                             a.Adres
                         }).ToList();

            dgEkran.DataSource = sorgu;
        }        

        private void btnAdminGuncelle_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();

            ID = (int)dgEkran.SelectedRows[0].Cells[0].Value;
            this.Hide();
            FrmAdminGuncelle frm = new FrmAdminGuncelle();
            frm.Show();
        }

        private void btnAdminSil_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();
            ID = (int)dgEkran.SelectedRows[0].Cells[0].Value;
            var ad = db.AdminSet.Find(ID);
            db.AdminSet.Remove(ad);
            db.SaveChanges();
            MessageBox.Show("İşleminiz gerçekleştirilmiştir.");
            tsBtnAdminler.PerformClick();
        }

        private void tsBtnKullanıcılar_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();

            var sorgu = (from k in db.KullaniciSet
                         select new
                         {
                             k.Id,
                             k.Unvan,
                             k.Adi,
                             k.Soyadi,
                             k.DogumTarihi,
                             k.Telefon,
                             k.Mail,
                             k.CezaDurumu,
                             k.CezaSayisi
                         }).ToList();

            dgEkran.DataSource = sorgu;
        }

        private void tsBtnKategoriler_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();

            var sorgu = (from k in db.KategoriSet
                         select new
                         {
                             k.Id,
                             k.KategoriAdi
                         }).ToList();

            lstListeler.DataSource = sorgu;
            lstListeler.DisplayMember = "KategoriAdi";
            lstListeler.ValueMember = "Id";
        }

        private void tsBtnYazarlar_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();

            var sorgu = (from y in db.YazarSet
                         select new
                         {
                             y.Id,
                             AdiSoyadi = y.YazarAdi + " " + y.YazarSoyadi
                         }).ToList();

            lstListeler.DataSource = sorgu;
            lstListeler.DisplayMember = "AdiSoyadi";
            lstListeler.ValueMember = "Id";
        }

        private void tsBtnYayinEvleri_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();

            var sorgu = (from y in db.YayinEviSet
                         select new
                         {
                             y.Id,
                             y.YayinEviAdi
                         }).ToList();

            lstListeler.DataSource = sorgu;
            lstListeler.DisplayMember = "YayinEviAdi";
            lstListeler.ValueMember = "Id";
        }

        private void tsBtnSonEklenenler_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();

            DateTime trh = DateTime.Now.AddMonths(-1);

            var sorgu = (from k in db.KitapSet
                         where k.EklenmeTarihi >= trh
                         select new
                         {
                             k.Id,
                             k.KitapAdi,
                             k.SayfaSayisi,
                             k.TasnifNo,
                             k.Kategori.KategoriAdi,
                             k.YayinEvi.YayinEviAdi,
                             k.KiralikDurumu,
                             k.KiralanmaTarihi,
                             k.İadeTarihi,
                             k.EklenmeTarihi,
                             YazarAdSoyad = k.Yazar.YazarAdi + " " + k.Yazar.YazarSoyadi
                         }).ToList();

            dgEkran.DataSource = sorgu;
           
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();
            ID = (int)dgEkran.SelectedRows[0].Cells[0].Value;
            var klnc = db.KullaniciSet.Find(ID);
            db.KullaniciSet.Remove(klnc);
            db.SaveChanges();
            MessageBox.Show("İşleminiz gerçekleştirilmiştir.");
            tsBtnKullanıcılar.PerformClick();

        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKitapEkle frm = new FrmKitapEkle();
            frm.Show();
        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();

            ID = (int)dgEkran.SelectedRows[0].Cells[0].Value;
            this.Hide();
            FrmKitapGuncelle frm = new FrmKitapGuncelle();
            frm.Show();
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();
            ID = (int)dgEkran.SelectedRows[0].Cells[0].Value;
            var ktp = db.KitapSet.Find(ID);
            db.KitapSet.Remove(ktp);
            db.SaveChanges();
            MessageBox.Show("İşleminiz gerçekleştirilmiştir.");

            var sorgu = (from k in db.KitapSet                        
                         select new
                         {
                             k.Id,
                             k.KitapAdi,
                             k.SayfaSayisi,
                             k.TasnifNo,
                             k.Kategori.KategoriAdi,
                             k.YayinEvi.YayinEviAdi,
                             k.KiralikDurumu,
                             k.KiralanmaTarihi,
                             k.İadeTarihi,
                             k.EklenmeTarihi,
                             YazarAdSoyad = k.Yazar.YazarAdi + " " + k.Yazar.YazarSoyadi
                         }).ToList();

            dgEkran.DataSource = sorgu;

        }
    }
}
