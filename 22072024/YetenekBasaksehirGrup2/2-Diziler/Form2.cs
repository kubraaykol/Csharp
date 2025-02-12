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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac = sayac + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac = 10;
        }
        int counter = 0;
        string[] ogrenciListesi = new string[1];
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //öğrenci adını ve soyadını alarak birleştirelim, string bir dizi oluşturarak ekleme yapalım. 

            string adSoyad = txtName.Text + " " + txtSurname.Text;

            ogrenciListesi[counter] = adSoyad;
            //sayac = sayac + 1;
            counter++;

            int elemanSayisi = ogrenciListesi.Length;

            Array.Resize(ref ogrenciListesi, elemanSayisi + 1);


        }
    }
}
