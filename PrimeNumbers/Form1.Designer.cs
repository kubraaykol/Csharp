namespace PrimeNumbers
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
            lstPrimeNumber = new ListBox();
            btnList = new Button();
            txtNumber = new TextBox();
            btnGet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // lstPrimeNumber
            // 
            lstPrimeNumber.FormattingEnabled = true;
            lstPrimeNumber.Location = new Point(12, 136);
            lstPrimeNumber.Name = "lstPrimeNumber";
            lstPrimeNumber.Size = new Size(190, 264);
            lstPrimeNumber.TabIndex = 1;
            // 
            // btnList
            // 
            btnList.Location = new Point(151, 77);
            btnList.Name = "btnList";
            btnList.Size = new Size(94, 29);
            btnList.TabIndex = 2;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(92, 17);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(125, 27);
            txtNumber.TabIndex = 3;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(12, 77);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(94, 29);
            btnGet.TabIndex = 4;
            btnGet.Text = "GetPrimes";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGet);
            Controls.Add(txtNumber);
            Controls.Add(btnList);
            Controls.Add(lstPrimeNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstPrimeNumber;
        private Button btnList;
        private TextBox txtNumber;
        private Button btnGet;
    }
}
