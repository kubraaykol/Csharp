namespace RectangleDraw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Uzun kenar uzunluğu:");
            int uzunKenar=int.Parse(Console.ReadLine());
            Console.Write("Kısa kenar uzunluğu");
            int kisaKenar=int.Parse(Console.ReadLine());

            for (int i=0; i<kisaKenar; i++)
            {
                for(int j=0; j<kisaKenar; j++)
                {
                    Console.Write(" * ");
                }

                Console.WriteLine();
            }
            Console.WriteLine("\n================\n");
            for (int i = 0; i < kisaKenar; i++)
            {
                for (int j = 0; j < uzunKenar; j++)
                {
                    if(i!=j)
                    {
                        Console.Write(" * ");

                    }
                    else
                    {
                        Console.Write("   ");
                    }
                    
                }

                Console.WriteLine();
            }
        }
    }
}
