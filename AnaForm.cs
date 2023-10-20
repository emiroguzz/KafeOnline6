using KafeOnline6.Data;

namespace KafeOnline6
{
    public partial class AnaForm : Form
    {
        KafeVeri db = new KafeVeri();
        public AnaForm()
        {
            InitializeComponent();
            OrnekUrunleriYukle();
            MasalariYukle();
        }

        private void OrnekUrunleriYukle()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Çay", BirimFiyat = 20.00m });
            db.Urunler.Add(new Urun() { UrunAd = "Kola", BirimFiyat = 35.00m });
            db.Urunler.Add(new Urun() { UrunAd = "Gözleme", BirimFiyat = 120.00m });
            db.Urunler.Add(new Urun() { UrunAd = "Omlet", BirimFiyat = 70.00m });
        }

        private void MasalariYukle()
        {
            for (int i = 0; i < db.MasaAdet; i++)
            {
                ListViewItem lvi = new ListViewItem();
                int masaNo = i +1;
                lvi.Text = "Masa " + masaNo;
                lvi.Tag = masaNo;
                lvi.ImageKey = "bos";
                lvwMasalar.Items.Add(lvi);
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = lvwMasalar.SelectedItems[0];
            lvi.ImageKey = "dolu";
            int masaNo = (int)lvi.Tag;
            Siparis? siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);

            if (siparis == null)
            {
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
            }

            SiparisForm siparisForm = new SiparisForm(db, siparis);
            siparisForm.ShowDialog();

            if (siparis.Durum != SiparisDurum.Aktif)
                lvi.ImageKey = "bos";
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            new GecmisSiparislerForm(db).ShowDialog();
        }
    }
}