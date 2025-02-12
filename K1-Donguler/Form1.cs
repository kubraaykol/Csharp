using System.ComponentModel.DataAnnotations;

namespace K1_Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] kategoriListesi = new string[] { "Elektronik, Teknoloji", "Ev Gereçleri", "Bahçe Malzemelri" };
        private void button1_Click(object sender, EventArgs e)
        {
            lstListe.Items.Clear();
            //For Döngüsü
            //Tüm kategorileri 1.Elektronik þeklinde listeye ekleyiniz.
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
            foreach (var item in kategoriListesi)
            {
                lstListe.Items.Add((item));
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Do While
            //Hiçbir koþula bakýlmaksýzýn yazdýðýmýz kodlar en az bir defa çalýþýr. Koþul kontrolü sonradan yapýlýr.

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
                    //döngü bu adýmý atlar ve bir sonraki adýmdan çalýþmaya devam eder.
                    continue;
                }
                lstListe.Items.Add(item);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var item in kategoriListesi)
            {
                if (item=="Ev Gereçleri")
                {
                    break;
                }
                lstListe.Items.Add(item);
            }
        }
    }
}
