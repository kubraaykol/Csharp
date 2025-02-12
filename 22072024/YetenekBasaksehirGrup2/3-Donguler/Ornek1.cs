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
    public partial class Ornek1 : Form
    {
        public Ornek1()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            //aranan harfin cümle içerisinde kaç adet olduğunu yazdıracağız.
            string arananCumle = txtCumle.Text.ToLower();
            //char c= arananCumle[2];
            char arananHarf = Convert.ToChar(txtAranan.Text.ToLower());

            int harfAdedi = 0;

            foreach (var item in arananCumle)
            {
                if (item == arananHarf)
                {
                    harfAdedi++;
                }
            }

            lblMesaj.Text = harfAdedi.ToString();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            //Cümle içinde bütün aranan harfleri bularak, X 'e dönüştürelim.
            string arananCumle = txtCumle.Text.ToLower();
            char arananHarf = Convert.ToChar(txtAranan.Text.ToLower());

            string yeniCumle = "";

            for (int i = 0; i < arananCumle.Length; i++)
            {
                if (arananCumle[i] == arananHarf)
                {
                    yeniCumle = arananCumle.Replace(arananCumle[i], 'X');
                }
            }

            txtCumle.Text = yeniCumle;
        }

        string[] categories = new string[] { "RAM", "HDD", "CPU", "VGA", "BOARD" };
        private void btnDizideAra_Click(object sender, EventArgs e)
        {
            //Kategoriler içerisinde bulunan HDD kategorisini SSD ile değişiriniz.

            //IndexOf metodu
            //Dizi içirisinde bulunan elemanın index değerini döner. Bulamaz ise -1 döner.

            int indexNo = Array.IndexOf(categories, "HDD");

            if (indexNo != -1)
            {
                categories[indexNo] = "SSD";
            }
            else
            {
                MessageBox.Show("Aradığınız kategori bulunamadı.");
            }


        }
    }
}
