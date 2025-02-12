using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace _8_regularExpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Regular Expression (Düzenli Ýfadeler)
            /*Metinler içerisinde belirli kalýplarý bulmak ve geliþtirmek için kullanýlan 
                dizelerdir.bir mezin içerisindeki örüntüleri tanýmlamak için kullanýlan
                özel karakter ve sembollerin kombinasyonudur.
            
             [0-9] rakamsal deðerler girilsin
             [^0-9] rakam girilmesin
            [a-z] sadece küçük harf alfabetik karakterler
            [A-Z] sadece büyük harf alfabetik karakterler
            [A-Za-z0-9] rakam girilmesin
            [^0-9] rakam girilmesin
             */




        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(txtSayi.Text, "[^0-9]"))
                {
                    throw new Exception("Lütfen sayýsal bir deðer giriniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSayi.Text, "[^A-Za-z]"))
            {
                MessageBox.Show("Lütfen alfabetik bir deðer giriniz");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             E - posta deseni 1: @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"
             E - posta deseni 2: @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|org|net|edu|gov|biz|info|io|name{2,})$"
             Telefon numarasý deseni: @"0\([0-9]{3}\)-[0-9]{3}-[0-9]{2}-[0-9]{2}"
             Tarih deseni: @"^\d{1,2}\/\d{1,2}\/\d{4}$"
            */

            string pattern1 = @"0\([0-9]{3}\)-[0-9]{3}-[0-9]{2}-[0-9]{2}";
            string pattern2 = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|org|net|edu|gov|biz|info|io|name{2,})$";

            if (Regex.IsMatch(txtDeger.Text)
        }
    }
}
