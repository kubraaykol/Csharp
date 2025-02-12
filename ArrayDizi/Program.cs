namespace ArrayDizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities1 = { "Ankara", "İstanbul", "İzmir", "Adana", "Bursa" };
            string[] cities2 = new string[6];
            //cities2[0] = cities1[0];
            //cities2[1] = cities1[1];
            //cities2[2] = cities1[2];
            //cities2[3] = cities1[3];
            //cities2[4] = cities1[4];
            //cities2[5] = "Antalya";
            //cities1 = cities2;
            //foreach (var city in cities1)
            //{
            //    Console.WriteLine(city);
            //}
            for (int i = 0; i < cities1.Length; i++)
            {
                cities2[i] = cities1[i];
            }
            cities2[5] = "Antalya";
            cities1 = cities2;

            List<string> cityList = new List<string>();
            //cityList.Add("Ankara");
            //cityList.Add("İstanbul");
            //cityList.Add("İzmir");


            cityList.AddRange(cities1);
            foreach(var city in cityList)
            {
                Console.WriteLine(city);
            }
        }
    }
}
