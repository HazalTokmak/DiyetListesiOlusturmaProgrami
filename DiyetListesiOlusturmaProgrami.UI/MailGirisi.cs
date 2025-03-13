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
           

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            txtMail.Text=txtAd.Text+ txtSoyad.Text;
            MailGonder(txtMail.Text); //ayrı buton yap

        }
        private void MailGonder(string mesaj)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("aysehazaltokmak.yzl@gmail.com");//göndere e posta
                mail.To.Add("@gmail.com");//göndeirlen
                mail.Subject = "Yapılıcaklar Listesi";
                mail.Body = mesaj;

                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("aysehazaltokmak.yzl@gmail.com", "xzotvfbwkpxjbrxv");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Gönderildi");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
