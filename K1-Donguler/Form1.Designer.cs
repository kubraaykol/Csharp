namespace K1_Donguler
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
            button1 = new Button();
            lstListe = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(1, 15);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(675, 53);
            button1.TabIndex = 0;
            button1.Text = "For Döngüsü";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 25;
            lstListe.Location = new Point(726, 28);
            lstListe.Margin = new Padding(4);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(328, 479);
            lstListe.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(1, 87);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(675, 61);
            button2.TabIndex = 2;
            button2.Text = "While Döngüsü";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1, 167);
            button3.Name = "button3";
            button3.Size = new Size(675, 64);
            button3.TabIndex = 3;
            button3.Text = "ForEach";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1, 250);
            button4.Name = "button4";
            button4.Size = new Size(675, 62);
            button4.TabIndex = 4;
            button4.Text = "Do While";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(-9, 334);
            button5.Name = "button5";
            button5.Size = new Size(685, 62);
            button5.TabIndex = 5;
            button5.Text = "Continue";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(4, 419);
            button6.Name = "button6";
            button6.Size = new Size(672, 59);
            button6.TabIndex = 6;
            button6.Text = "Break";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 562);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lstListe);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox lstListe;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
