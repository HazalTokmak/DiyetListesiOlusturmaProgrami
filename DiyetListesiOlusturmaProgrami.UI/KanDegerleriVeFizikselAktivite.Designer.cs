namespace DiyetListesiOlusturmaProgrami.UI
{
    partial class KanDegerleriVeFizikselAktivite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KanDegerleriVeFizikselAktivite));
            cmbKanDegerleri = new ComboBox();
            cmbFizikselAktivite = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnGec = new Button();
            txtKanDegerleri = new TextBox();
            txtFizikselAktiviteler = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnCikis = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cmbKanDegerleri
            // 
            cmbKanDegerleri.BackColor = Color.Firebrick;
            cmbKanDegerleri.FormattingEnabled = true;
            cmbKanDegerleri.Location = new Point(52, 83);
            cmbKanDegerleri.Name = "cmbKanDegerleri";
            cmbKanDegerleri.Size = new Size(333, 28);
            cmbKanDegerleri.TabIndex = 0;
            // 
            // cmbFizikselAktivite
            // 
            cmbFizikselAktivite.BackColor = SystemColors.Highlight;
            cmbFizikselAktivite.FormattingEnabled = true;
            cmbFizikselAktivite.Location = new Point(707, 82);
            cmbFizikselAktivite.Name = "cmbFizikselAktivite";
            cmbFizikselAktivite.Size = new Size(333, 28);
            cmbFizikselAktivite.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(196, 31);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 1;
            label1.Text = "Kan Değerlerinizi Giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(832, 31);
            label2.Name = "label2";
            label2.Size = new Size(225, 20);
            label2.TabIndex = 1;
            label2.Text = "Fiziksel Aktivitelerinizi Giriniz";
            // 
            // btnGec
            // 
            btnGec.BackColor = Color.FromArgb(255, 224, 192);
            btnGec.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnGec.Location = new Point(466, 555);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(288, 83);
            btnGec.TabIndex = 2;
            btnGec.Text = "GEÇ:";
            btnGec.UseVisualStyleBackColor = false;
            // 
            // txtKanDegerleri
            // 
            txtKanDegerleri.BackColor = Color.IndianRed;
            txtKanDegerleri.Location = new Point(432, 83);
            txtKanDegerleri.Multiline = true;
            txtKanDegerleri.Name = "txtKanDegerleri";
            txtKanDegerleri.Size = new Size(107, 27);
            txtKanDegerleri.TabIndex = 3;
            // 
            // txtFizikselAktiviteler
            // 
            txtFizikselAktiviteler.BackColor = Color.FromArgb(192, 192, 255);
            txtFizikselAktiviteler.Location = new Point(1086, 83);
            txtFizikselAktiviteler.Name = "txtFizikselAktiviteler";
            txtFizikselAktiviteler.Size = new Size(107, 27);
            txtFizikselAktiviteler.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(746, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 318);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(106, 188);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(354, 335);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = (Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.Location = new Point(1208, 0);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(23, 24);
            btnCikis.TabIndex = 5;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // KanDegerleriVeFizikselAktivite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1230, 666);
            Controls.Add(btnCikis);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtFizikselAktiviteler);
            Controls.Add(txtKanDegerleri);
            Controls.Add(btnGec);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbFizikselAktivite);
            Controls.Add(cmbKanDegerleri);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KanDegerleriVeFizikselAktivite";
            Text = "KanDegerleriVeFizikselAktivite";
            Load += KanDegerleriVeFizikselAktivite_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbKanDegerleri;
        private ComboBox cmbFizikselAktivite;
        private Label label1;
        private Label label2;
        private Button btnGec;
        private TextBox txtKanDegerleri;
        private TextBox txtFizikselAktiviteler;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnCikis;
    }
}