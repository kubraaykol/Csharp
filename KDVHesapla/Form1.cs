using System.Data;
using System.Security.Permissions;

namespace KDVHesapla //KDVHesapla adýnda bir isim alaný oluþturur.
{
    public partial class Form1 : Form //"Form1" sýnýfý, bir Windows formdur ve "form" sýnýfýndan türetilmiþtir.
    {
        private List<decimal> totals; //"totals" adýnda "decimal" türünde deðerler içeren özel bir liste tanýmlanýr. Bu liste, sepetteki ürünlerin fiyatlarýný tutar.
        public Form1() //"Form1 sýnýfýnýn yapýcý metodudur.. Form oluþturulduðunda çalýþýr. 
        {
            totals = new List<decimal>(); //totals listesini baþlatýr.
            InitializeComponent(); //formun bileþenlerini baþlatýr. Bu metod genellikle otomatik oluþturulur ve formun kontrollerini baþlatýr.
        }

        private void btnEkle_Click(object sender, EventArgs e) //btnEkle butonuna týklandýðýnda çalýþan metottur.
        {
            totals.Add(Convert.ToDecimal(txtPrice.Text));//"txtPrice" adlý metin kutusundaki deðeri "decimal"e çevirir ve "totals" listesine ekler.
            ListFill();//"totals" listesini görüntüler
            Clear(); //"txtPrice" metin kutusunu temizler.
        }

        void ListFill()//"totals listesindeki deðerleri "lstShopping" adlý liste kutusunda görüntüler.
        {
            //lstShopping.Items.Clear();
            //foreach (var item in totals)
            //{
            //lstShopping.Items.Add(item);
            //}

            lstShopping.DataSource = null; 
            lstShopping.DataSource = totals;
            //bu iki satýr veri kaynaðýný önce boþaltýp sonra yeniden "totals" listesine ayarlar. bu, liste kutusunun güncellenmesini saðlar.
        }

        void Clear()
        {
            txtPrice.Clear();
            //Clear metodu "txtPrice" metin kutusunu temizler.
        }

        decimal TotalPrice(List<decimal> sepet)// "sepet" listesindeki tüm fiyatlarý toplar.
        {
            decimal total = 0;// toplam fiyatý saklamak için bir deðiþken tanýmlar.
            foreach (decimal price in sepet)//sepet  listesindeki her fiyatý döngüyle toplar.
                //+Parametre:Bir metodun tanýmýnda, metodun alacaðý verileri tanýmlayan deðiþkenlerdir. "TotalPrice" metodunda "sepet" bir parametredir ve "List<decimal>" türündedir.
                //+Argüman:Bir metod çaðrýldýðýnda, metodun parametrelerine saðlanan gerçek verilerdi. "total=ToralPrice(totals); ifadesinde "totals" listesi argüman olarak "TotalPrice" metoduna geçirilir.
            {
                total += price;//Okunuþu:totatl deðiþkenine, price deðiþkeninin deðeri kadar ekle. total= total+price ile ayný anlam.
                               //total deðiþkeninin mevcut deðerine "price"deðiþkeninin deðerini ekler ve sonucu tekrar "total" deðiþkenine atar. yani mevcut deðere baþka bir deðeri eklemek için kullanýrýz.
            }
            return total; //toplam fiyatý döndürür.
        }

        decimal KDVHesapla(decimal total, int oran = 20)//KDV hesaplamak için kullanýlan bir metodun imzasýdýr.Metodun iþlevi, verilen bir toplam tutar üzerinden belirli bir kdv oranýný hesaplamak ve bu oraný varsayýlan olarak %20 kullanmak.

            //"decimal" bu metodun dönüþ türüdür."KDVHesapla ise metodun adýdýr. 
            //"decimal total, metosun ilk parametresidir."total", "decimal" türünde bir deðiþkendir ve bu deðiþken KDV'nin hesaplanacaðý toplam tutarý temsil eder.

            //int oran=20 metosun ikinci parametresidir ve varsayýlan bir deðere sahiptir. 20 kýsmý, bu metod çaðýrýldýðýnda bu parametre belirtilmezse oran deðeri olarak otomatik olarak 20 olacaktýr. 
        {
            return total * oran / 100;//okunuþu: total deðiþkeninin deðerini oran deðiþkeninin deðeri ile çarp, sonra sonucu 100'e böl ve bu deðeri döndür.
        }

        private void btnHesapla_Click(object sender, EventArgs e) //btnHesapla butonuna týklandýðýnda çalýþan metottur.
        {
            decimal total = TotalPrice(totals);//TotalPrice adlý bir metodu çaðýrarak "totals" listesindeki tüm deðerlerin toplamýný hesaplar ve sonucu "total" adlý bir deðiþkende saklar.

            //decimal total bileþeninde "total bir deðiþken tanýmlar. decimal de finanasal ve para birimi iþlemler için kullanýlýr. 
            //sað taraftaki deðeri sol tarafýndaki deðiþkene atar.

            //"TotalPrice" metosunu çaðýrýr ve "totals" adlý liste bu metoda argüman olarak geçirilir. 

            //"argüman olarak deçirilir: bir metodun çaðýrýldýðý sýrada o metoda veri saðlamak anlamýna gelir.
            //Bu veri, metodun iþlemlerini gerçekleþtirmek için kullanýlýr ve metodun parametreleri bu verileri temsil eder.

            //+decimal total = TotalPrice(totals); 
            //metod çaðrýlýyor. "total" adlý liste "TotalPrice" metoduna argüman olarak saðlanýyor.
            //+Argüman Saðlama:"TotalPrice" metodunun parametresi olan "sepet", çaðrý sýrasýnda "totals" listesinin referansýný alýr.
            //+Metod içinde Ýþlem:"sepet" parametresi, metodun içinde "totals" listesini temsil eder. Metodun içindeki döngü,"totals" listesindeki her fiyat deðerini toplar.
            //totalPrice(totals); -> totals listesi TotalPrice metoduna argüman olarak seçilir.
            //+"sepet parametresi totlas listesini referans alýr.
            //+total deðiþkeni baþlangýçta 0 olarak tanýmlanýr.
            //+foreach döngüsü sepet yani totals listesindeki her "price" deðeri için çalýþýr ve bu deðerleri "total" deðiþkenine ekler.
            //+Toplam fiyat hesaplandýktan sonra total deðeri döndürülür.

            decimal kdv =KDVHesapla(TotalPrice(totals), Convert.ToInt32(txtKdv.Text));
            string message = "";//Mesajý oluþturmak için bir deðiþken tanýmlar.
            message += $"Sepetteki ürünlerin toplam fiyatý:{total}";//Toplam fiyatý mesaja ekler.
            message +=$"\nSepetteki ürünlerin KDV tutarý: {kdv}";//KDV tutarýný mesaja ekler.
            message +=$"\nSepetteki ürünlerin KDVli Toplam Tutarý { total+kdv}";//KDV dahil toplam fiyatý mesaja ekler.
            MessageBox.Show(message);//Mesajý bir mesaj kutusunda gösterir.

        }
    }
}
