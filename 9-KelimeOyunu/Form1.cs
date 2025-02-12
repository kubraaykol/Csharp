namespace _9_KelimeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //groupbox'a 1 adet buton ekleme:
            Button btn = new Button();
            btn.Size = new Size(90, 90);
            btn.Location = new Point();
            btn.Text = "--";
            btn.Name = "btn1";
            //this.Controls.Add(btn);
            grpHarfler.Controls.Add(btn);

        }
    }
}
