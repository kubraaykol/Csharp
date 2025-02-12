namespace _3_Donguler
{
    partial class Ornek1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCumle = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnDizideAra = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranan Harf";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(12, 55);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(178, 41);
            this.txtAranan.TabIndex = 1;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(12, 188);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(277, 57);
            this.btnDegistir.TabIndex = 2;
            this.btnDegistir.Text = "Bul ve Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 33;
            this.lstListe.Location = new System.Drawing.Point(672, 16);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(263, 367);
            this.lstListe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arama Cümlesi";
            // 
            // txtCumle
            // 
            this.txtCumle.Location = new System.Drawing.Point(12, 141);
            this.txtCumle.Name = "txtCumle";
            this.txtCumle.Size = new System.Drawing.Size(654, 41);
            this.txtCumle.TabIndex = 1;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(295, 188);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(277, 57);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Arama Yap";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnDizideAra
            // 
            this.btnDizideAra.Location = new System.Drawing.Point(12, 251);
            this.btnDizideAra.Name = "btnDizideAra";
            this.btnDizideAra.Size = new System.Drawing.Size(560, 57);
            this.btnDizideAra.TabIndex = 2;
            this.btnDizideAra.Text = "Dizide Arama Yap";
            this.btnDizideAra.UseVisualStyleBackColor = true;
            this.btnDizideAra.Click += new System.EventHandler(this.btnDizideAra_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.Location = new System.Drawing.Point(264, 33);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(356, 80);
            this.lblMesaj.TabIndex = 0;
            // 
            // Ornek1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(947, 402);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.btnDizideAra);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.txtCumle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Ornek1";
            this.Text = "Ornek1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCumle;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnDizideAra;
        private System.Windows.Forms.Label lblMesaj;
    }
}