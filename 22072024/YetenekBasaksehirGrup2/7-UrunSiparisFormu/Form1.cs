namespace _7_UrunSiparisFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal[] tutarDizisi = new decimal[1];
        private void Form1_Load(object sender, EventArgs e)
        {
            //ComboboxKategorileriGetirGetValues();
            ComboboxKategorileriGetirGetNames();
            UrunleriHazirla();
        }
        Dictionary<string, string> urunListesi = new Dictionary<string, string>();
        private void UrunleriHazirla()
        {
            urunListesi.Add("Iphone 14 Pro Max", "Elektronik");
            urunListesi.Add("HP Laptop", "Elektronik");
            urunListesi.Add("Kurutma Makinesi", "EvEþyalari");
            urunListesi.Add("Samsung HD TV", "EvEþyalari");
            urunListesi.Add("Çaydanlýk", "EvEþyalari");
            urunListesi.Add("Saksý", "BahçeMalzemeleri");
            urunListesi.Add("Bahçe Oturma Grubu", "BahçeMalzemeleri");
        }

        private void ComboboxKategorileriGetirGetValues()
        {
            byte[] dizi = (byte[])Enum.GetValues(typeof(Kategoriler));
            //Array dizi = Enum.GetValues(typeof(Kategoriler));

            foreach (var item in dizi)
            {
                cmbKategori.Items.Add(item);
            }
        }

        private void ComboboxKategorileriGetirGetNames()
        {
            string[] tumKategoriler = Enum.GetNames(typeof(Kategoriler));

            foreach (var item in tumKategoriler)
            {
                cmbKategori.Items.Add(item);
            }
        }

        decimal kdvliTutar;
        int sayac = 0;
        private void btnAktar_Click(object sender, EventArgs e)
        {
            int deger = 200;
            //string mesaj = deger == 100 ? "evet 100" : "Hayýr deðil";

            if (RadioButtonKontrol())
            {
                //kurumsal fatura kdv %20
                //bireysel fatura kdv %18

                //Ternary IF Ýfadesi

                bool hangiFatura = rdKurumsal.Checked ? true : false;

                if (hangiFatura)
                {
                    //kurumsal fatura iþlemi
                    kdvliTutar = nmrAdet.Value * decimal.Parse(txtBirimFiyat.Text) * 1.20m;

                }
                else
                {
                    //bireysel fatura iþlemi
                    kdvliTutar = nmrAdet.Value * decimal.Parse(txtBirimFiyat.Text) * 1.18m;
                }

                //Listbox'a Ekleme Yapalým:
                lstSepet.Items.Add($"{secilenUrun}-{nmrAdet.Value}-{txtBirimFiyat.Text}-{kdvliTutar}");
                tutarDizisi[sayac] = kdvliTutar;
                sayac++;

                Array.Resize(ref tutarDizisi, tutarDizisi.Length + 1);

                lblSepetToplam.Text = ToplamGuncelle().ToString();

            }
        }

        private decimal ToplamGuncelle()
        {
            decimal toplam = 0;
            foreach (var item in tutarDizisi)
            {
                toplam += item;
            }

            return toplam;
        }

        private bool RadioButtonKontrol()
        {
            bool durum = false;

            foreach (var item in grpFaturaTipleri.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton radio = item as RadioButton;
                    if (radio.Checked)
                    {
                        durum = true;
                    }
                }
            }

            return durum;
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbKategori.SelectedIndex==-1 demek comboboxtan herhangi birþey seçilmediði anlamýna gelir.

            if (cmbKategori.SelectedIndex != -1)
            {
                lstListe.Items.Clear();

                string secilen = cmbKategori.SelectedItem.ToString();

                foreach (var item in urunListesi)
                {
                    if (item.Value == secilen)
                    {
                        lstListe.Items.Add(item.Key);
                    }
                }
            }
        }

        string secilenUrun;
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //secilen birþey varsa;
            if (lstListe.SelectedIndex != -1)
            {
                secilenUrun = lstListe.SelectedItem.ToString();
            }
        }

        private void txtBirimFiyat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal sonuc = nmrAdet.Value * decimal.Parse(txtBirimFiyat.Text);
                txtToplamTutar.Text = sonuc.ToString();
            }
        }
    }
}
