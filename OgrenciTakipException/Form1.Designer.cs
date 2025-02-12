namespace OgrenciTakipException
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
            lblAdSoyad = new Label();
            txtAdSoyad = new TextBox();
            lstListe = new ListBox();
            btnHesapla = new Button();
            lblVize = new Label();
            txtVize = new TextBox();
            txtFinal = new TextBox();
            lblFinal = new Label();
            lblMesaj = new Label();
            SuspendLayout();
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(12, 9);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(73, 20);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(12, 41);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(277, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.Location = new Point(12, 188);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(277, 184);
            lstListe.TabIndex = 2;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(152, 379);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(181, 59);
            btnHesapla.TabIndex = 3;
            btnHesapla.Text = "Ortalama Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // lblVize
            // 
            lblVize.AutoSize = true;
            lblVize.Location = new Point(12, 90);
            lblVize.Name = "lblVize";
            lblVize.Size = new Size(74, 20);
            lblVize.TabIndex = 4;
            lblVize.Text = "Vize Notu";
            // 
            // txtVize
            // 
            txtVize.Location = new Point(12, 126);
            txtVize.Name = "txtVize";
            txtVize.Size = new Size(125, 27);
            txtVize.TabIndex = 5;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(164, 126);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(125, 27);
            txtFinal.TabIndex = 6;
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(164, 90);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(77, 20);
            lblFinal.TabIndex = 7;
            lblFinal.Text = "Final Notu";
            // 
            // lblMesaj
            // 
            lblMesaj.Location = new Point(36, 441);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(253, 43);
            lblMesaj.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 508);
            Controls.Add(lblMesaj);
            Controls.Add(lblFinal);
            Controls.Add(txtFinal);
            Controls.Add(txtVize);
            Controls.Add(lblVize);
            Controls.Add(btnHesapla);
            Controls.Add(lstListe);
            Controls.Add(txtAdSoyad);
            Controls.Add(lblAdSoyad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdSoyad;
        private TextBox txtAdSoyad;
        private ListBox lstListe;
        private Button btnHesapla;
        private Label lblVize;
        private TextBox txtVize;
        private TextBox txtFinal;
        private Label lblFinal;
        private Label lblMesaj;
    }
}
