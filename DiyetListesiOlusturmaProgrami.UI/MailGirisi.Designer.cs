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
            lblIsim = new Label();
            txtAd = new TextBox();
            btnUyelikOlustur = new Button();
            lblSoyAd = new Label();
            lblMail = new Label();
            txtSoyad = new TextBox();
            txtMail = new TextBox();
            SuspendLayout();
            // 
            // lblIsim
            // 
            lblIsim.AutoSize = true;
            lblIsim.Location = new Point(146, 83);
            lblIsim.Name = "lblIsim";
            lblIsim.Size = new Size(31, 20);
            lblIsim.TabIndex = 0;
            lblIsim.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(269, 83);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(216, 27);
            txtAd.TabIndex = 1;
            txtAd.TextChanged += textBox1_TextChanged;
            // 
            // btnUyelikOlustur
            // 
            btnUyelikOlustur.Location = new Point(432, 280);
            btnUyelikOlustur.Name = "btnUyelikOlustur";
            btnUyelikOlustur.Size = new Size(184, 50);
            btnUyelikOlustur.TabIndex = 2;
            btnUyelikOlustur.Text = "Üyelik Oluştur";
            btnUyelikOlustur.UseVisualStyleBackColor = true;
            btnUyelikOlustur.Click += btnUyelikOlustur_Click;
            // 
            // lblSoyAd
            // 
            lblSoyAd.AutoSize = true;
            lblSoyAd.Location = new Point(146, 142);
            lblSoyAd.Name = "lblSoyAd";
            lblSoyAd.Size = new Size(53, 20);
            lblSoyAd.TabIndex = 0;
            lblSoyAd.Text = "Soyad:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(146, 199);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(41, 20);
            lblMail.TabIndex = 0;
            lblMail.Text = "Mail:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(269, 142);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(216, 27);
            txtSoyad.TabIndex = 1;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(269, 199);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(216, 27);
            txtMail.TabIndex = 1;
            txtMail.TextChanged += txtMail_TextChanged;
            // 
            // MailGirisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUyelikOlustur);
            Controls.Add(txtMail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblMail);
            Controls.Add(lblSoyAd);
            Controls.Add(lblIsim);
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
        private TextBox txtMail;
    }
}