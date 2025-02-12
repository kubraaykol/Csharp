namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "kübra aykol";
            //UPPERCase 
            Console.WriteLine(name.ToUpper());
            string ilce = "ÜSKÜDAR";
            Console.WriteLine(ilce.ToLower());
            string metin = "What is Lorem Ipsum?Lorem Ipsum is simply  " +
                "industry's standard dummy text ever since the 1500s, " +
                "when an unkprinter took a galley of type and scrambled " +
                "it to make a type book. It has survived not only five centuries," +
                " but also the leap into ";

            if (metin.Contains("canlandırma"))
            {
                Console.WriteLine(metin);
            }
            else
            {
                Console.WriteLine("aranan kelime bulunamadı");
            }

            if (metin.EndsWith("nir"))
            {
                Console.WriteLine("Metin nir. ile başlıyor");
            }

            else
            {
                Console.WriteLine("Metin nir ile bitmiyor ");
            }
            if (metin.StartsWith("nir"))
            {
                Console.WriteLine("Metin nir. ile başlıyor");
            }

            else
            {
                Console.WriteLine("Metin nir ile bitmiyor ");
            }

            string word = "Metotlar";
            string word2 = word.Insert(0, "Parametreli ");
            Console.WriteLine(word2);

            word2 = word2.Replace(oldChar:' ', newChar: '-');
            Console.WriteLine(word2);

            string subMetin = "Gözleme dayalı olan anlatım türüdür";
            string subMetin1 = subMetin.Substring(10);
            Console.WriteLine(subMetin1);
            string subMetin2= subMetin.Substring(startIndex:5, length:10);
            Console.WriteLine(subMetin2);


            //split string metin içerisinde istediğimiz
            string aylar = "Ocak,Şubat,Mart,Nisan,Mayıs,Haziran,Temmuz,Ağustos,Eylül,Ekim,Kasım,Aralık ";
            string[] aylarListesi=aylar.Split(separator:",");
            foreach (var ay in aylarListesi)
            {
                Console.WriteLine(ay);
            }

            //metinin sonucunu bir değişkene atayabiliyorsak metod değer dönüyor deriz.

            string metin3 = " ";

        }
    }
}
