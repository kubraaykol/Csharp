namespace ArrayReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities1 = { "Ankara", "İstanbul", "İzmir", "Adana", "Bursa" };
            string[] cities2 = cities1;
            cities1[1] = "Çanakkale";
            Console.WriteLine(cities2[1]);

            List<string> seas = new List<string>
            {
                "Marmara",
                "Ege",
                "akdeniz",
                "Karadeniz"
            };
            Console.WriteLine(seas[1]);

        }
    }
}
