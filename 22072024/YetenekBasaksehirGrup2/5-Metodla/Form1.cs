using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Metodla
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
             METODLAR
            Program içerisinde aynı işi yapan satırları belirli bir düzende bir araya getirdiğimiz yapılardır. Gerektiğinde çağırarak tekrar tekrar kullanabiliriz. Metodlar sayesinde kod tekrarları yapmadan daha anlaşılır bir şekilde kodlama yapılabilir. 

             Direkt olarak çalışmazlar, program içerisinde çağırılarak çalışırlar. 

             Metod Türleri:

             1-Geriye Değer Dönmeyen Metodlar:
                 a-Parametresiz Metodlar
                 b-Parametreli Metodlar

             2-Geriye Değer Dönen Metodlar:
                 a-Parametresiz Metodlar
                 b-Parametreli Metodlar

             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MesajVer();
        }

        private void MesajVer()
        {
            MessageBox.Show("Welcome");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendMessage("Merhaba arkadaşlar, eğitim nasıl gidiyor?");
        }

        private void SendMessage(string m)
        {
            MessageBox.Show(m, "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SendMessage("Nasılsın");
            RenkDegistir();
        }

        private void RenkDegistir()
        {
            this.BackColor = Color.Coral;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool[] dizi = new bool[] { true, false, true, false, false };

            DiziSifirlama(dizi, true);
        }

        private void DiziSifirlama(bool[] dizi, bool v)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = v;
            }
        }

        /// <summary>
        /// Geriye girilen değerle birlikte bir mesaj döner.
        /// </summary>
        /// <param name="ad">string ad</param>
        /// <param name="soyad">string soyad</param>
        /// <returns>Girilen değerleri yan yana yazarak hoşgeldiniz mesajı verir.</returns>
        private string MesajGonder(string ad, string soyad)
        {
            return $"Hoş Geldiniz {ad} {soyad}";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string gelenMesaj = MesajGonder();
            string gelenMesaj1 = MesajGonder("Kuzey Mollaoğlu");
            string gelenMesaj2 = MesajGonder("Kuzey", "Mollaoğlu");
            string gelenMesaj3 = MesajGonder("Ahmet", "Aksakal");
        }

        //METOD OVERLOADING (Metodun aşırı yüklenmesi, burada önemli olan parametre sayısını ya da tipini farklılaştırmaktır.
        private string MesajGonder()
        {
            return "Hoş geldiniz";
        }

        private string MesajGonder(string s)
        {
            return $"Hoş Geldiniz {s}";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*
             Ref anathar kelimesi C# dilinde işaretcilerin yerini tutar, ref anahtar kelimesi ile kullanılan değişkene mutlaka bir ilkleme işlemi yapılmalıdır yani değişkene bir değer atanmış olmalıdır.

            Başlangıç değeri olan bir değişkenin değerini değiştirmek istiyoruz.
             */

            int sayi = 1;
            DegerDegistir(ref sayi);
            MessageBox.Show(sayi.ToString());
        }

        private void DegerDegistir(ref int sayi)
        {
            sayi = 100;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ad = "Ahmet";
            string soyad = "Aksakal";
            string adSoyad;

            CumleBirlestir(ad,ref soyad,out adSoyad);

            lstListe.Items.Add(ad);         //Ahmet
            lstListe.Items.Add(soyad);      //Genç
            lstListe.Items.Add(adSoyad);    //Kuzey Genç


        }

        private void CumleBirlestir(string ad,ref string soyad,out string adSoyad)
        {
            ad = "Kuzey";
            soyad = "Genç";
            adSoyad = ad + " " + soyad;
        }
    }
}
