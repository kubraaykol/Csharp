using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Random

            Random rnd = new Random();
            //0 dahil, 10 dahil değil
            int randomSayi = rnd.Next(0, 10);
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            lstKupon.Items.Clear();

            Random rnd = new Random();
            int randomSayi;

            int[] secilenSayilar = new int[6];

            for (int i = 0; i < 6; i++)
            {
                do
                {
                    randomSayi = rnd.Next(6, 50);
                } while (secilenSayilar.Contains(randomSayi));

                secilenSayilar[i] = randomSayi;
            }

            foreach (var item in secilenSayilar)
            {
                lstKupon.Items.Add(item);
            }

        }
    }
}
