using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             DİZİLER (ARRAYS)
            Dizi içerisinde aynı tipte birden çok değeri tutabilen ve indis(index) numaraları üzerinden bun değerlere ulaşabildiğimiz bir veri yapısıdır. Dizi içerisinde bulunan değerlere o dizinin elemanları denir. Dizi oluştururken eleman sayısının tanımlanması gerekiyor. 
             */


            //Dizi Oluşturma:
            string[] studentInfo = new string[4];
            //Eleman Sayısı: 4
            //Indis Degerleri : 0,1,2,3

            int[] sayiListesi = new int[4];

            //Diziyi oluşturduğum anda değerlerini atayabilirim.
            string[] sehirler = new string[] { "İstanbul", "Ankara", "İzmir", "Malatya" };

            //Diziye Değer Atama: (set)
            studentInfo[0] = "Ahmet Aksakal";
            studentInfo[1] = "54";
            studentInfo[2] = "Hasan Uzun";
            studentInfo[3] = "Erhan Kaplan";
            //studentInfo[4] = "Caner";

            //Diziden Değer Okuma: (get)
            string gelenDeger = studentInfo[3];
        }
    }
}
