namespace KDVHesapla
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
            btnEkle = new Button();
            btnHesapla = new Button();
            label2 = new Label();
            lstShopping = new ListBox();
            txtPrice = new TextBox();
            txtKdv = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(234, 12);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(234, 74);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(94, 29);
            btnHesapla.TabIndex = 1;
            btnHesapla.Text = "hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 2;
            label2.Text = "Tutar";
            // 
            // lstShopping
            // 
            lstShopping.FormattingEnabled = true;
            lstShopping.Location = new Point(21, 137);
            lstShopping.Name = "lstShopping";
            lstShopping.Size = new Size(179, 264);
            lstShopping.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(85, 12);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 4;
            // 
            // txtKdv
            // 
            txtKdv.Location = new Point(85, 74);
            txtKdv.Name = "txtKdv";
            txtKdv.Size = new Size(125, 27);
            txtKdv.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 82);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 6;
            label1.Text = "KDV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtKdv);
            Controls.Add(txtPrice);
            Controls.Add(lstShopping);
            Controls.Add(label2);
            Controls.Add(btnHesapla);
            Controls.Add(btnEkle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Button btnHesapla;
        private Label label2;
        private ListBox lstShopping;
        private TextBox txtPrice;
        private TextBox txtKdv;
        private Label label1;
    }
}
