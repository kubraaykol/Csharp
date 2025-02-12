namespace MultiplicationTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hangi sayının çarpım tablosu yazılsın");
            //int number=Convert.ToInt32(Console.ReadLine());

            void WriteTable(int x)
            {
               // for (int i=x; i==x; i++)
                //{
                    //for (int j=1; j<=10; j++)
                    //{
                       // Console.WriteLine($"{i,3} x {j,3}={i * j,3}");
                   // }
                   // Console.WriteLine("\n************************\n");
               // }

                for (int i = 1; i<=10; i++)
                {
                    Console.WriteLine($"{x,3 } X {i,3}={x*i,3}");

                }
            }

            //WriteTable(number);

            //for (int i=2; i<10; i++) 
            //{ 
            //for (int j=1; j<=10; j++)
            //{
            //Console.WriteLine($"{i,3} X {j,3}= {i*j,3}");
            // }

            //Console.WriteLine("\n************************\n");
            //}
            //Console.Write("Hangi sayının çarpım tablosu yazılsın:");
            //number=Consvert.ToInt32(Console.ReadLine());
            //WriteTable(number);
        }
    }
}
