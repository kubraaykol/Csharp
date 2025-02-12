namespace OgrenciTakipException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, double> ogrenciListesi = new Dictionary<string, double>();

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //TRY CATCH (Hata Yakalama)
            //bütün iþlemer TRY bloðu içerisinde yapýlýr.
            //catch:herhangi bir hata oluþuþrsa bu blok devreye girer. burada exception nesnesi üzerinden  hata ile ilgili bilgilere ulaþabiliriz.
            //finally: her iki durumda da bu bölüm her þekilde çalýþýr.

            try
            {
                //form üzerinden deðerleri alalým:
                if (string.IsNullOrEmpty(txtAdSoyad.Text) || string.IsNullOrEmpty(txtFinal.Text) || string.IsNullOrEmpty(txtVize.Text))
                {
                    throw new Exception("Lütfen tüm alanlarý doldurunuz!");
                }
                else
                {
                    string adSoyad = txtAdSoyad.Text;
                    double vizeNotu = Convert.ToDouble(txtVize.Text);
                    double finalNotu = Convert.ToDouble(txtFinal.Text);

                    double ortalama = OrtalamaHesapla(vizeNotu, finalNotu);
                    //deðerleri dictionary yapýsýna ekleyelim:
                    ogrenciListesi[adSoyad] = ortalama;
                    //Listeye tüm öðrencileri ekleyelim:
                    ListeyiGuncelle();
                }
            }

            catch (Exception ex)
            {
                lblMesaj.Text = ex.Message;
            }
            finally
            {

            }
        }
        private void ListeyiGuncelle()
        {
            lstListe.Items.Clear();

            foreach (var item in ogrenciListesi)

            {
                lstListe.Items.Add($"{item.Key}-{item.Value}");
            }
        }
        private double OrtalamaHesapla(double vizeNotu, double finalNotu)
        {
            double ortalama = (vizeNotu * 0.4) + (finalNotu * 0.6);
            return ortalama;
        }
    }

}
            


