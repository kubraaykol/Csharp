namespace TrangleDraw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Giriniz: ");
            int height = int.Parse(Console.ReadLine());
            int[,] point = new int[height, height];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j<=i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
    }
}
