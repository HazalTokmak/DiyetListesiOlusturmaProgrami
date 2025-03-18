namespace DiyetListesiOlusturmaProgrami.UI
{
    partial class MailGirisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailGirisi));
            lblIsim = new Label();
            txtAd = new TextBox();
            btnUyelikOlustur = new Button();
            lblSoyAd = new Label();
            lblMail = new Label();
            txtSoyad = new TextBox();
            cmbMail = new ComboBox();
            btnMailSec = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // lblIsim
            // 
            lblIsim.AutoSize = true;
            lblIsim.BackColor = Color.Transparent;
            lblIsim.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblIsim.Location = new Point(294, 15);
            lblIsim.Name = "lblIsim";
            lblIsim.Size = new Size(33, 20);
            lblIsim.TabIndex = 0;
            lblIsim.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(358, 8);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(216, 27);
            txtAd.TabIndex = 1;
            txtAd.TextChanged += textBox1_TextChanged;
            // 
            // btnUyelikOlustur
            // 
            btnUyelikOlustur.BackColor = Color.FromArgb(255, 255, 192);
            btnUyelikOlustur.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUyelikOlustur.Location = new Point(364, 500);
            btnUyelikOlustur.Name = "btnUyelikOlustur";
            btnUyelikOlustur.Size = new Size(210, 68);
            btnUyelikOlustur.TabIndex = 2;
            btnUyelikOlustur.Text = "Üyelik Oluştur";
            btnUyelikOlustur.UseVisualStyleBackColor = false;
            btnUyelikOlustur.Click += btnUyelikOlustur_Click;
            // 
            // lblSoyAd
            // 
            lblSoyAd.AutoSize = true;
            lblSoyAd.BackColor = Color.Transparent;
            lblSoyAd.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblSoyAd.Location = new Point(283, 56);
            lblSoyAd.Name = "lblSoyAd";
            lblSoyAd.Size = new Size(56, 20);
            lblSoyAd.TabIndex = 0;
            lblSoyAd.Text = "Soyad:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.BackColor = Color.Transparent;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblMail.Location = new Point(294, 99);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(45, 20);
            lblMail.TabIndex = 0;
            lblMail.Text = "Mail:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(358, 49);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(216, 27);
            txtSoyad.TabIndex = 1;
            // 
            // cmbMail
            // 
            cmbMail.FormattingEnabled = true;
            cmbMail.Location = new Point(358, 91);
            cmbMail.Name = "cmbMail";
            cmbMail.Size = new Size(216, 28);
            cmbMail.TabIndex = 3;
            // 
            // btnMailSec
            // 
            btnMailSec.BackColor = Color.FromArgb(255, 255, 192);
            btnMailSec.Location = new Point(595, 71);
            btnMailSec.Name = "btnMailSec";
            btnMailSec.Size = new Size(80, 48);
            btnMailSec.TabIndex = 4;
            btnMailSec.Text = "Mail Seç";
            btnMailSec.UseVisualStyleBackColor = false;
            btnMailSec.Click += btnMailSec_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = (Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.Location = new Point(900, -1);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(23, 24);
            btnCikis.TabIndex = 6;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // MailGirisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(922, 593);
            Controls.Add(btnCikis);
            Controls.Add(btnMailSec);
            Controls.Add(cmbMail);
            Controls.Add(btnUyelikOlustur);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblMail);
            Controls.Add(lblSoyAd);
            Controls.Add(lblIsim);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MailGirisi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MailGirisi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIsim;
        private TextBox txtAd;
        private Button btnUyelikOlustur;
        private Label lblSoyAd;
        private Label lblMail;
        private TextBox txtSoyad;
        private ComboBox cmbMail;
        private Button btnMailSec;
        private Button btnCikis;
    }
}