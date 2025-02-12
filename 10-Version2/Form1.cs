namespace _10_Version2
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
        string secilenKelime;
        private void button1_Click(object sender, EventArgs e)
        {
            string[] Sehirler = new string[] { "ankara", "istanbul", "bursa", "izmir" };
            Random rnd=new Random();
            int randomSehirIndex=rnd.Next(0, Sehirler.Length);//Rastgele bir þehir seç
            string randomSehir = Sehirler[randomSehirIndex];

            int harfSayisi=randomSehir.Length;

            groupBox1.Controls.Clear();

            for(int i=0; i<harfSayisi; i++)
            {
                butonGetir(new Size(40, 40));
            }

        }

        private void butonGetir(Size size, Point location)
        {
            Button btn = new Button();
            btn.Size = size;
            btn.Location = location;
            btn.Text = "--";
            btn.Name
        }
    }
}
