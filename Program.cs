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

            // Opdracht1();
            Opdracht2();
        }
        // Opdracht 2 uit de Powerpoint (slide 17/28)
        static void Opdracht2()
        {
            File.ReadAllText("C:\\Users\\gally\\Documents\\SCHOOL\\CODING\\CSHARP\\ws1.txt");
        }

        // Opdracht 1 uit de Powerpoint (slide 14/28)
        static void Opdracht1()
        {
            Console.WriteLine("Hello C#sharp lesson!");
            Console.WriteLine("Can you give me your name?");
            string name = Console.ReadLine();
            Console.WriteLine("And what is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and your age is {1}", name, age);
            Console.ReadKey();
            Console.WriteLine("Could you give me your last name as well?");
            string lastname = Console.ReadLine();
            int years = 65 - age;
            Console.WriteLine("Dear {0}, in {1} years, you will be 65+ years old!", lastname, years);
            Console.WriteLine("..And you will receive a 65+ pass. Congrats!");
        }

    }
}