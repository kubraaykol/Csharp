using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cümle içinde bütün aranan harfleri bularak, x'e dönüştürelim
            for (int i=0; arananCumle.Length; i++)
            {
                if (arananCumle[i]==arananHarf)
                {
                    arananCumle.Replace(arananCumle[i], = 'X'); 
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //arana harfin cümle içerisinde kaç adet old. yazdıracağız
            string arananCumle=txt
            char harf=(Convert.ToChar(textBox2.Text));
            int sayi = 0;
            foreach (int c in textBox1.Text)
            {
                if (c == harf)
                {
                    sayi++;
                }
            }
            listBox1.Items.Add(sayi);
        }

            string[] categories = new string[] { "RAM", "HDD", "CPU", "VGA", "BOARD" };
            private void textBox2_TextChanged(object sender, EventArgs e)
        { 
             //KAtegoriler içerisinde bulunan HDD kategorisini SSd ile değiştririniz
             //IndexOf metodu 
             //Dizi içerisinde bulunan elemanın index değerini döner. Bulamaz ise -1 döner.

                int indexNo=Array.IndexOf
        
        }
    }
}
