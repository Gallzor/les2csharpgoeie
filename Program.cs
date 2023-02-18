namespace Les2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //hier komt alles te staan wat je runt
            //Program.cs is je index/view

            //hier maak je de = new var();
            //writeline ook hier, vergeet de dollarsign niet($"");

            Opdracht1();
        }
        static void Opdracht1()
        {
            Console.WriteLine("Hello C#sharp lesson!");
            Console.WriteLine("Can you give me your name?");
            string name = Console.ReadLine();
            Console.WriteLine("And what is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You name is {0}, and your age is {1}!");
            Console.ReadKey();
            Console.WriteLine("Could you give me your lastname as well?");
            string lastname = Console.ReadLine();
            int years = 65 - age;
            Console.WriteLine("Dear {2}, in {3} years, you will be 65+ years old!");
            Console.WriteLine("..And you will receive a 65+ pass. Congrats!");
        }

    }
}