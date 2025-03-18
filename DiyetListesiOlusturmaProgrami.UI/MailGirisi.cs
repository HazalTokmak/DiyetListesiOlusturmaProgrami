using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace DiyetListesiOlusturmaProgrami.UI
{
    public partial class MailGirisi : Form
    {
        public MailGirisi()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUyelikOlustur_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz");
                return;
            }
            //StringBuilder mailIcerik = new StringBuilder();
            //mailIcerik.AppendLine("Yapılıcaklar Listesi");
            //mailIcerik.AppendLine("-----------------------");

            //MailGonder(mailIcerik.ToString());

            BKİHesaplama bKİHesaplama = new BKİHesaplama();
            bKİHesaplama.ShowDialog();


        }

        //private void txtMail_TextChanged(object sender, EventArgs e)
        //{
        //    Random random = new Random();

        //    cmbMail.Items.Clear();

        //    string adSoyad = txtAd.Text.Trim() + txtSoyad.Text.Trim();
        //    cmbMail.Items.Add(adSoyad);

        //    for (int i = 0; i < 4; i++)
        //    {
        //        int rastgeleSayi = random.Next(1, 10);
        //        cmbMail.Items.Add(adSoyad + rastgeleSayi.ToString());
        //    }


        //}
        private void MailGonder(string mesaj)
        {




            string ad = (txtAd.Text + "." + txtSoyad.Text + "@gmail.com");



            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("aysehazaltokmak.yzl@gmail.com");//göndere e posta
                mail.To.Add("@gmail.com");//göndeirlen
                mail.Subject = "Yapılıcaklar Listesi";
                mail.Body = mesaj;

                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("gönderen mail", "gönderilen şifre");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Gönderildi");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMailSec_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            cmbMail.Items.Clear();

            string adSoyad = txtAd.Text.Trim() + txtSoyad.Text.Trim();
            string mail = "@gmail.com";
            char[] noktalama = new char[] { '.', '_', '-' };
            //cmbMail.Items.Add(adSoyad);

            for (int i = 0; i < 3; i++)
            {
                int rastgeleSayi = random.Next(1, 10);
                char rastgeleNoktalama = noktalama[random.Next(0, noktalama.Length)];
                cmbMail.Items.Add(adSoyad + rastgeleNoktalama + rastgeleSayi.ToString() + mail);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
