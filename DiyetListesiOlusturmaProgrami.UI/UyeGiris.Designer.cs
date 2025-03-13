namespace DiyetListesiOlusturmaProgrami.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            btnGec = new Button();
            chcUyelikYok = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            msktxtTelefonNumarasi = new MaskedTextBox();
            txtSifre = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(382, 104);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(501, 101);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(179, 27);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // btnGec
            // 
            btnGec.Image = (Image)resources.GetObject("btnGec.Image");
            btnGec.Location = new Point(719, 304);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(97, 108);
            btnGec.TabIndex = 2;
            btnGec.UseVisualStyleBackColor = true;
            btnGec.Click += btnGec_Click;
            // 
            // chcUyelikYok
            // 
            chcUyelikYok.AutoSize = true;
            chcUyelikYok.BackColor = Color.FromArgb(255, 255, 192);
            chcUyelikYok.Location = new Point(501, 266);
            chcUyelikYok.Name = "chcUyelikYok";
            chcUyelikYok.Size = new Size(113, 24);
            chcUyelikYok.TabIndex = 3;
            chcUyelikYok.Text = "Üye Değilim";
            chcUyelikYok.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(438, 163);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(352, 218);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 0;
            label3.Text = "Telefon Numarası";
            // 
            // msktxtTelefonNumarasi
            // 
            msktxtTelefonNumarasi.Location = new Point(501, 215);
            msktxtTelefonNumarasi.Mask = "(999) 000-0000";
            msktxtTelefonNumarasi.Name = "msktxtTelefonNumarasi";
            msktxtTelefonNumarasi.Size = new Size(179, 27);
            msktxtTelefonNumarasi.TabIndex = 4;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(501, 156);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(179, 27);
            txtSifre.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(719, 304);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 5;
            label4.Text = "İleri:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(844, 449);
            Controls.Add(label4);
            Controls.Add(msktxtTelefonNumarasi);
            Controls.Add(chcUyelikYok);
            Controls.Add(btnGec);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKullaniciAdi;
        private Button btnGec;
        private CheckBox chcUyelikYok;
        private Label label2;
        private Label label3;
        private MaskedTextBox msktxtTelefonNumarasi;
        private TextBox txtSifre;
        private Label label4;
    }
}
