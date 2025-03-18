using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetListesiOlusturmaProgrami.UI
{
    public partial class BKİHesaplama : Form
    {
        public BKİHesaplama()
        {
            InitializeComponent();
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt3GunlukBesinTuketimKaydi.Text == null && txtAslaHayirDiyemecegi1.Text == null && txtAslaHayirDiyemecegi2.Text == null && txtAslaHayirDiyemecegi3.Text == null && txtAslaYememDiyecegi1.Text == null && txtAslaYememDiyecegi2.Text == null && txtAslaYememDiyecegi3.Text == null && txtBoy.Text == null && txtKilo.Text == null && txtYas.Text == null)
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
                    return;
                }
                if (txtBoy.Text.All(char.IsLetter) || txtKilo.Text.All(char.IsLetter) || txtYas.Text.All(char.IsLetter) || txtBoy.Text.All(char.IsPunctuation) || txtKilo.Text.All(char.IsPunctuation) || txtYas.Text.All(char.IsPunctuation))
                {
                    MessageBox.Show("Harf ya da noktalama işareti girişi yapamazsınız");
                    return;
                }
                if (txtAslaYememDiyecegi1.Text.All(char.IsDigit) || txtAslaYememDiyecegi1.Text.All(char.IsPunctuation) || txtAslaYememDiyecegi2.Text.All(char.IsDigit) || txtAslaYememDiyecegi3.Text.All(char.IsDigit) || txtAslaHayirDiyemecegi1.Text.All<char>(char.IsDigit) || txtAslaHayirDiyemecegi2.Text.All<char>(char.IsDigit) || txtAslaHayirDiyemecegi3.Text.All<char>(char.IsDigit) || txt3GunlukBesinTuketimKaydi.Text.All<char>(char.IsPunctuation) || txtAslaYememDiyecegi1.Text.All(char.IsPunctuation) || txtAslaYememDiyecegi2.Text.All(char.IsPunctuation) || txtAslaYememDiyecegi3.Text.All(char.IsPunctuation) || txtAslaHayirDiyemecegi1.Text.All<char>(char.IsPunctuation) || txtAslaHayirDiyemecegi2.Text.All<char>(char.IsPunctuation) || txtAslaHayirDiyemecegi3.Text.All<char>(char.IsPunctuation) || txt3GunlukBesinTuketimKaydi.Text.All<char>(char.IsPunctuation))
                {
                    MessageBox.Show("Sayı ya da noktalama işareti girişi yapamazsınız.");
                    return;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            KanDegerleriVeFizikselAktivite kanDegerleriVeFizikselAktivite = new KanDegerleriVeFizikselAktivite();
            kanDegerleriVeFizikselAktivite.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
