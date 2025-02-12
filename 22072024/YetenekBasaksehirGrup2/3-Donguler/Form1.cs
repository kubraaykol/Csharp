using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] kategoriListesi = new string[] { "Elektronik", "Teknoloji", "Ev Gereçleri", "Bahçe Malzemeleri" };
        private void button1_Click(object sender, EventArgs e)
        {
            lstListe.Items.Clear();
            //For Döngüsü
            //Tüm kategorileri 1. Elektronik şeklinde listboxa ekleyiniz.

            for (int i = 0; i < kategoriListesi.Length; i++)
            {
                lstListe.Items.Add($"{i + 1}.{kategoriListesi[i]}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayac = 0;

            while (sayac < kategoriListesi.Length)
            {
                lstListe.Items.Add(kategoriListesi[sayac]);
                sayac++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var deger = 45.45332;



            foreach (var item in kategoriListesi)
            {
                lstListe.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Do While 
            //Hiçbir koşula bakılmaksızın yazdığımız kodlar en az 1 defa çalışır. Koşul kontrolü sonradan yapılır.
            int sayac = 0;

            do
            {
                lstListe.Items.Add(sayac);
                sayac++;
            } while (sayac <= 5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var item in kategoriListesi)
            {
                if (item == "Elektronik")
                {
                    //döngü bu adımı atlar ve bir sonraki adımdan çalışmaya devam eder.
                    continue;
                }
                lstListe.Items.Add(item);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var item in kategoriListesi)
            {
                if (item == "Ev Gereçleri")
                {
                    break;
                }
                lstListe.Items.Add(item);
            }
        }
    }
}
