namespace ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "istanbul", "ankara", "izmir", "erzurum", "sivas" };
            //indexof methodu aranan değerin dizinin kaçıncı indexinde
            //olduğu bilgisini verir

            Console.WriteLine($"izmir değeri dizinin " +
                $"{Array.IndexOf(cities, "izmir")}.indexinde bulunmaktadır");

            Array.Sort(cities);
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            foreach (var team in teams)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine(teams[2]);
            teams.Sort();
            foreach(var team in teams)
        }
    }
}
