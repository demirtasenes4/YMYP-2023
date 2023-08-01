namespace _06.Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> names = new();
            names.Add("BTC");
            names.Add("ETH");
            names.Add("AVAX");
            names.Add("VET");
            names.Add("BAT");
            names.Add("FET");
            names.Add("XLM");

            //Console.WriteLine(name[0]);
            //Console.WriteLine(name[1]);
            //Console.WriteLine(name[2]);
            //Console.WriteLine(name[3]);
            //Console.WriteLine(name[4]);
            //Console.WriteLine(name[5]);

            //for, foreach

            for (int x = 0; x < names.Count(); x++)
            {
                if(x == 4)
                {
                    break;
                }
                if(x == 0)
                {
                    continue;
                }
                if(x == 3)
                {
                    continue;
                }
                Console.WriteLine(names[x]);
            }

            //foreach (var x in names)
            //{
            //    Console.WriteLine(x);
            //}

        }
    }
}