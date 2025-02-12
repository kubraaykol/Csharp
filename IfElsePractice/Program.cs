namespace IfElsePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan not girmesini isteyiniz:
            //girilen not;
            //85-100 A
            //84-70 B
            //69-55 C
            //54-45 D
            //44 ve aşağısı F
            //Girilen nota göre kullanıcıya girilen notun karşılığında çıktı dönülecektir.
            byte not;
            while (true)
            {
                Console.Write("\nNotunuzu giriniz : ");
                not = Convert.ToByte(Console.ReadLine());

                if (not >= 85 && not < 100)
                {
                    Console.WriteLine("A ile Dersten Geçtiniz");
                }
                else if (not >= 70 && not < 84)
                {
                    Console.WriteLine("B ile Dersten Geçtiniz");
                }
                else if (not >= 55 && not < 69)
                {
                    Console.WriteLine("C ile Dersten Geçtiniz");
                }
                else if (not >= 45 && not < 54)
                {
                    Console.WriteLine("D ile Dersten Koşullu Geçtiniz");
                }
                else if (not <= 44)
                {
                    Console.WriteLine("F ile Dersten Kaldınız");
                }

            }
        }
    }
}

