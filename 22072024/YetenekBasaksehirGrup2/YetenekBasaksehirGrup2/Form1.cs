using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YetenekBasaksehirGrup2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //tek yorum satırı
        /*
        Event-Driven (Olay Güdümlü)

         */

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             DEĞİSKENLER (Variables)
            Bilgisayar belleğinde bazı değerleri tutmaya yarayan yapılardır.
             */

            //İsimlendirme standardı olarak camelCase kullanıyoruz.
            //C# case sensitive bir dildir. Yani büyük küçük harf duyarlıdır.

            byte stokMiktari = 255;
            int sayi = 5;
            short deger = 32000;

            float ondalikSayi1 = 465.44f;
            double ondalikSayi2 = 4434.43;
            decimal ondalikSayi3 = 4323.23m;

            string nameSurname = "Ahmet Aksakal";
            char karakter = 'E';

            bool cevap = true;
            bool Cevap = true;

            //Value Type - Referans Type
            //Dizilerle birlikte örneklendireceğiz.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
