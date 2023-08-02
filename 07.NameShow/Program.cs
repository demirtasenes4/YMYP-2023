using System.ComponentModel.Design;

namespace _07.NameShow
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Lütfen isminizi giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hoşgeldin " + name + "!");

            Random random = new Random();
            int randomNumber = random.Next(1, 11); // Generates a random number between 1 and 10 (inclusive).

            while (true)
            {

                Console.WriteLine("Lütfen 1 ile 10 arasında bir sayı gir: ");

                string number = Console.ReadLine();
                int number1 = int.Parse(number);


                if (randomNumber == number1)
                {
                    Console.WriteLine("Contratulations, you guessed right!");
                    break;
                }
                else
                {
                    Console.WriteLine("Unfortunately wrong, try again!");
                }
            }

        
        }
    }
}