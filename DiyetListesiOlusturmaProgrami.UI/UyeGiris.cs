namespace DiyetListesiOlusturmaProgrami.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGec_Click(object sender, EventArgs e)
        {

            if (txtKullaniciAdi.Text == null || string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || txtSifre.Text == null || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen Alanlarý Boþ Býrakmayýnýz");
                return;
            }
            if (!(txtKullaniciAdi.Text == null || string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || txtSifre.Text == null || string.IsNullOrWhiteSpace(txtSifre.Text)))
            {
                BKÝHesaplama bKÝHesaplama = new BKÝHesaplama();
                bKÝHesaplama.ShowDialog();
            }


            if (!chcUyelikYok.Checked)
            {

                btnGec.Enabled = true;
                MailGirisi mailGirisii = new MailGirisi();
                mailGirisii.Show();
                return;
            }

            if (txtKullaniciAdi.Text == null || txtSifre.Text == null || msktxtTelefonNumarasi.Text == null)
            {
                MessageBox.Show("Lütfen Boþ Alanlarý Doldurunuz!");
                return;
            }
            try
            {
                KullaniciBilgileri kullaniciBilgileri = new KullaniciBilgileri()
                {
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text,
                    Telefon = msktxtTelefonNumarasi.Text,
                };

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            MailGirisi mailGirisi = new MailGirisi();
            mailGirisi.Show();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
