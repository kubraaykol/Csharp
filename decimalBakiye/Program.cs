namespace decimalBakiye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal bakiye = 0;

            void ParaYatir(decimal tutar)
            {
                bakiye += tutar;
            }
            ParaYatir(1000);
            Console.WriteLine($"Bakiye:{bakiye}");

            decimal ParaYatirBakiyeGoster(decimal tutar)
            {
                bakiye += tutar;
                return bakiye;
            }

            decimal sonBakiye = ParaYatirBakiyeGoster(15000);
            Console.WriteLine($"Son Bakiye:{sonBakiye}");
        }
    }
}
