namespace _6_OgrenciTakip
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
            txtAdSoyad = new TextBox();
            lstListe = new ListBox();
            btnHesapla = new Button();
            label2 = new Label();
            txtVize = new TextBox();
            label3 = new Label();
            txtFinal = new TextBox();
            lblMesaj = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(130, 37);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(18, 66);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(614, 43);
            txtAdSoyad.TabIndex = 1;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(18, 220);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(602, 189);
            lstListe.TabIndex = 2;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(18, 415);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(602, 62);
            btnHesapla.TabIndex = 3;
            btnHesapla.Text = "NOT ORTALAMASI HESAPLA";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 122);
            label2.Name = "label2";
            label2.Size = new Size(134, 37);
            label2.TabIndex = 0;
            label2.Text = "Vize Notu";
            // 
            // txtVize
            // 
            txtVize.Location = new Point(18, 171);
            txtVize.Name = "txtVize";
            txtVize.Size = new Size(277, 43);
            txtVize.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 122);
            label3.Name = "label3";
            label3.Size = new Size(140, 37);
            label3.TabIndex = 0;
            label3.Text = "Final Notu";
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(343, 171);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(277, 43);
            txtFinal.TabIndex = 1;
            // 
            // lblMesaj
            // 
            lblMesaj.Location = new Point(29, 496);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(591, 63);
            lblMesaj.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 593);
            Controls.Add(lblMesaj);
            Controls.Add(btnHesapla);
            Controls.Add(lstListe);
            Controls.Add(txtFinal);
            Controls.Add(txtVize);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAdSoyad);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAdSoyad;
        private ListBox lstListe;
        private Button btnHesapla;
        private Label label2;
        private TextBox txtVize;
        private Label label3;
        private TextBox txtFinal;
        private Label lblMesaj;
    }
}
