namespace _7_UrunSiparisFormu
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
            label1 = new Label();
            cmbKategori = new ComboBox();
            lstListe = new ListBox();
            label2 = new Label();
            nmrAdet = new NumericUpDown();
            txtBirimFiyat = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtToplamTutar = new TextBox();
            grpFaturaTipleri = new GroupBox();
            rdBireysel = new RadioButton();
            rdKurumsal = new RadioButton();
            lstSepet = new ListBox();
            lblSepetToplam = new Label();
            btnAktar = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            grpFaturaTipleri.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(417, 46);
            label1.TabIndex = 0;
            label1.Text = "Lütfen Bir Kategori Seçiniz:";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(27, 72);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(326, 53);
            cmbKategori.TabIndex = 1;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 45;
            lstListe.Location = new Point(27, 171);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(326, 184);
            lstListe.TabIndex = 2;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 131);
            label2.Name = "label2";
            label2.Size = new Size(192, 46);
            label2.TabIndex = 0;
            label2.Text = "Ürün Listesi";
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(27, 426);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(188, 52);
            nmrAdet.TabIndex = 3;
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(221, 426);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(223, 52);
            txtBirimFiyat.TabIndex = 4;
            txtBirimFiyat.KeyDown += txtBirimFiyat_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 377);
            label3.Name = "label3";
            label3.Size = new Size(92, 46);
            label3.TabIndex = 0;
            label3.Text = "Adet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 377);
            label4.Name = "label4";
            label4.Size = new Size(175, 46);
            label4.TabIndex = 0;
            label4.Text = "Birim Fiyat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 495);
            label5.Name = "label5";
            label5.Size = new Size(216, 46);
            label5.TabIndex = 0;
            label5.Text = "Toplam Tutar";
            // 
            // txtToplamTutar
            // 
            txtToplamTutar.Location = new Point(27, 544);
            txtToplamTutar.Name = "txtToplamTutar";
            txtToplamTutar.Size = new Size(369, 52);
            txtToplamTutar.TabIndex = 4;
            // 
            // grpFaturaTipleri
            // 
            grpFaturaTipleri.Controls.Add(rdBireysel);
            grpFaturaTipleri.Controls.Add(rdKurumsal);
            grpFaturaTipleri.Location = new Point(544, 23);
            grpFaturaTipleri.Name = "grpFaturaTipleri";
            grpFaturaTipleri.Size = new Size(312, 185);
            grpFaturaTipleri.TabIndex = 5;
            grpFaturaTipleri.TabStop = false;
            grpFaturaTipleri.Text = "Fatura Tipi";
            // 
            // rdBireysel
            // 
            rdBireysel.AutoSize = true;
            rdBireysel.Location = new Point(19, 103);
            rdBireysel.Name = "rdBireysel";
            rdBireysel.Size = new Size(256, 50);
            rdBireysel.TabIndex = 0;
            rdBireysel.TabStop = true;
            rdBireysel.Text = "Bireysel Fatura";
            rdBireysel.UseVisualStyleBackColor = true;
            // 
            // rdKurumsal
            // 
            rdKurumsal.AutoSize = true;
            rdKurumsal.Location = new Point(19, 59);
            rdKurumsal.Name = "rdKurumsal";
            rdKurumsal.Size = new Size(281, 50);
            rdKurumsal.TabIndex = 0;
            rdKurumsal.TabStop = true;
            rdKurumsal.Text = "Kurumsal Fatura";
            rdKurumsal.UseVisualStyleBackColor = true;
            // 
            // lstSepet
            // 
            lstSepet.FormattingEnabled = true;
            lstSepet.ItemHeight = 45;
            lstSepet.Location = new Point(544, 239);
            lstSepet.Name = "lstSepet";
            lstSepet.Size = new Size(312, 229);
            lstSepet.TabIndex = 2;
            // 
            // lblSepetToplam
            // 
            lblSepetToplam.Location = new Point(687, 495);
            lblSepetToplam.Name = "lblSepetToplam";
            lblSepetToplam.Size = new Size(339, 37);
            lblSepetToplam.TabIndex = 0;
            // 
            // btnAktar
            // 
            btnAktar.Location = new Point(385, 219);
            btnAktar.Name = "btnAktar";
            btnAktar.Size = new Size(135, 117);
            btnAktar.TabIndex = 6;
            btnAktar.Text = ">>>";
            btnAktar.UseVisualStyleBackColor = true;
            btnAktar.Click += btnAktar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 611);
            Controls.Add(btnAktar);
            Controls.Add(grpFaturaTipleri);
            Controls.Add(txtToplamTutar);
            Controls.Add(txtBirimFiyat);
            Controls.Add(nmrAdet);
            Controls.Add(lstSepet);
            Controls.Add(lstListe);
            Controls.Add(cmbKategori);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblSepetToplam);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            grpFaturaTipleri.ResumeLayout(false);
            grpFaturaTipleri.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbKategori;
        private ListBox lstListe;
        private Label label2;
        private NumericUpDown nmrAdet;
        private TextBox txtBirimFiyat;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtToplamTutar;
        private GroupBox grpFaturaTipleri;
        private RadioButton rdBireysel;
        private RadioButton rdKurumsal;
        private ListBox lstSepet;
        private Label lblSepetToplam;
        private Button btnAktar;
    }
}
