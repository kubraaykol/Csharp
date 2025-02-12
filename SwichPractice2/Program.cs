namespace SwichPractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ile 7 arasında bir sayı giriniz");
            byte number = Convert.ToByte(Console.ReadLine());
            switch(number)
            {

                case 1:
                    Console.WriteLine("Seçtiniğiniz Gün Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Seçtiniğiniz Gün Salı");
                    break;
                case 3:
                    Console.WriteLine("Seçtiniğiniz Gün Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Seçtiniğiniz Gün Pazartesi");
                    break;

            }
        }
    }
}
