namespace DivideNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an array of numbers 1-100
            int[] numbers = new int[100];
            for (int i=0; i<100; i++)
            {
                numbers[i] = i+1;
            }
            for (int i = 0; i < 100; i++)
            {
                if (i %10==0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{numbers[i],4}");
            }
        }
    }
}
