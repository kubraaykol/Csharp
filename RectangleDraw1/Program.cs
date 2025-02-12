namespace RectangleDraw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("satır Giriniz: ");
            int height = int.Parse(Console.ReadLine());
            int[,]point =new int[height, height];
            for (int i = 0; i < height; i++)
            {
                for (int j= height; j>i; j--)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
