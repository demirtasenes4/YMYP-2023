namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + "!");

            // Generates a random number between 1 and 10 (inclusive).

            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int guess = 0;
            int tries = 1;

            while (randomNumber != guess)
            {

                Console.WriteLine("Please guess a number between 1 to 10: ");

                string number1 = Console.ReadLine();

                if (int.TryParse(number1, out guess) == false)
                {
                    Console.WriteLine("Please only enter numbers!");
                    continue;
                }

                int number = int.Parse(number1);

                if (guess > 10)
                {
                    Console.WriteLine("Please only enter numbers between 1 to 10!");
                    continue;
                }

                Console.WriteLine("Your guess: " + number);

                if (guess == randomNumber)
                {
                    Console.WriteLine($"Congratulations, you got it right in {tries} tries!");
                    guess = randomNumber;
                    continue;
                }

                Console.WriteLine("Unfortunately wrong! \nTry again! \n***");
                tries++;

            }
    }
}