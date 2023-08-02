namespace _02.DegerveReferansTipler
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");

            string name = "Enes";
            string name2 = name;
            name2 = "Emre";

            int tax1 = 10;
            int tax2 = tax1; // tax2 holds the value of tax1 (copies the value)
            tax1 = 20; // tax1 is changed, but tax2 still holds the original value 10.

            Console.WriteLine(name);
            Console.WriteLine(name2); //Example for value type

            Uber user1 = new();
            Uber user2 = user1; // user2 holds the reference to the same memory location as user1.
            user2.Name = "Emre"; // both user1 and user2 will reflect the change (same memory location).

            Console.WriteLine(user2.Name);
            Console.WriteLine(user1.Name);

        }

    }
}

class Uber // created an instance of the Uber class and assign it to the variable user1.
{
    public string Name = "Enes";

}