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
            cmbKanDegerleri = new ComboBox();
            cmbFizikselAktivite = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnGec = new Button();
            txtKanDegerleri = new TextBox();
            txtFizikselAktiviteler = new TextBox();
            SuspendLayout();
            // 
            // cmbKanDegerleri
            // 
            cmbKanDegerleri.FormattingEnabled = true;
            cmbKanDegerleri.Location = new Point(12, 82);
            cmbKanDegerleri.Name = "cmbKanDegerleri";
            cmbKanDegerleri.Size = new Size(333, 28);
            cmbKanDegerleri.TabIndex = 0;
            // 
            // cmbFizikselAktivite
            // 
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
            label1.Location = new Point(94, 31);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 1;
            label1.Text = "Kan Değerlerinizi Giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(763, 31);
            label2.Name = "label2";
            label2.Size = new Size(225, 20);
            label2.TabIndex = 1;
            label2.Text = "Fiziksel Aktivitelerinizi Giriniz";
            // 
            // btnGec
            // 
            btnGec.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnGec.Location = new Point(889, 542);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(288, 83);
            btnGec.TabIndex = 2;
            btnGec.Text = "GEÇ:";
            btnGec.UseVisualStyleBackColor = true;
            // 
            // txtKanDegerleri
            // 
            txtKanDegerleri.Location = new Point(386, 82);
            txtKanDegerleri.Multiline = true;
            txtKanDegerleri.Name = "txtKanDegerleri";
            txtKanDegerleri.Size = new Size(107, 27);
            txtKanDegerleri.TabIndex = 3;
            // 
            // txtFizikselAktiviteler
            // 
            txtFizikselAktiviteler.Location = new Point(1086, 83);
            txtFizikselAktiviteler.Name = "txtFizikselAktiviteler";
            txtFizikselAktiviteler.Size = new Size(107, 27);
            txtFizikselAktiviteler.TabIndex = 3;
            // 
            // KanDegerleriVeFizikselAktivite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 666);
            Controls.Add(txtFizikselAktiviteler);
            Controls.Add(txtKanDegerleri);
            Controls.Add(btnGec);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbFizikselAktivite);
            Controls.Add(cmbKanDegerleri);
            Name = "KanDegerleriVeFizikselAktivite";
            Text = "KanDegerleriVeFizikselAktivite";
            Load += KanDegerleriVeFizikselAktivite_Load;
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
    }
}