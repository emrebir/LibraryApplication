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
    public partial class FrmKitapEkle : Form
    {
        public FrmKitapEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ModelDBContainer db = new ModelDBContainer();

            Kitap ktp = new Kitap();

            ktp.KitapAdi = txtKitapAdi.Text;
            ktp.SayfaSayisi = int.Parse(txtSayfaSayisi.Text);
            ktp.EklenmeTarihi = dtEklenmeTarihi.Value;

            bool yazarVarMi = db.YazarSet.Where(y => y.YazarAdi == txtYazarAdi.Text && y.YazarSoyadi == txtYazarSoyadi.Text).ToList().Count > 0;

            if (yazarVarMi)
            {
                ktp.YazarId = db.YazarSet.Where(y => y.YazarAdi == txtYazarAdi.Text && y.YazarSoyadi == txtYazarSoyadi.Text).FirstOrDefault().Id;
            }
            else
            {
                var yzr = new Yazar();

                yzr.YazarAdi = txtYazarAdi.Text;
                yzr.YazarSoyadi = txtYazarSoyadi.Text;

                db.YazarSet.Add(yzr);
                
                ktp.YazarId = yzr.Id;
            }

            bool yEviVarMi = db.YayinEviSet.Where(y => y.YayinEviAdi == txtYayinEvi.Text).ToList().Count > 0;
            
            if (yEviVarMi)
            {
                ktp.YayinEviId = db.YayinEviSet.Where(y => y.YayinEviAdi == txtYayinEvi.Text).FirstOrDefault().Id;
            }
            else
            {
                var yEv = new YayinEvi();
                yEv.YayinEviAdi = txtYayinEvi.Text;

                db.YayinEviSet.Add(yEv);
                

                ktp.YayinEviId = yEv.Id;
            }

            bool ktgVarmi = db.KategoriSet.Where(k => k.KategoriAdi == txtKategori.Text).ToList().Count > 0;

            if (ktgVarmi)
            {
                ktp.KategoriId = db.KategoriSet.Where(k => k.KategoriAdi == txtKategori.Text).FirstOrDefault().Id;
            }
            else
            {
                var ktg = new Kategori();
                ktg.KategoriAdi = txtKategori.Text;
                db.KategoriSet.Add(ktg);
                

                ktp.KategoriId = ktg.Id;
            }

            Tasnif tsnf = new Tasnif();
            
            ktp.TasnifNo = tsnf.Tasnifle(txtKitapAdi.Text);

            db.KitapSet.Add(ktp);
            db.SaveChanges();

        }

       
    }
}
