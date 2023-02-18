using System.Data.Common;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Linq;

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
            //Opdracht2
            //Opdracht2IfElse();
            //Opdracht2Switch();
            Opdracht3();
        }

        // Opdracht 3 uit de Powerpoint (slide 26/28)
        //Niet af, moet vragen hoe double precies gaat en het uitlijnen
        static void Opdracht3()
        {

            string path = "C:\\Users\\gally\\Documents\\SCHOOL\\CODING\\CSHARP\\ws1.csv";
            string[] rows = File.ReadAllLines(path);

            foreach (string row in rows)
            {
                string[] columns = row.Split(';');

                foreach (string column in columns)
                {
                    Console.Write(column.Replace(',', '.') + "\t");
                }

                Console.WriteLine();
            }

        }

            // Opdracht 2 uit de Powerpoint (slide 17/28)
            static void Opdracht2()
        {

            string path = "C:\\Users\\gally\\Documents\\SCHOOL\\CODING\\CSHARP\\ws1.txt";

            string tekstbestand = File.ReadAllText(path);

            Console.WriteLine(tekstbestand);
        }

        //2e gedeelte opdracht: "Check of valide path word uitgevoerd" en
        //"Check of de file bestaat en de juiste extensie heeft: txt"
        // (slide 24/28)
        static void Opdracht2IfElse()
        {

            string path = "C:\\Users\\gally\\Documents\\SCHOOL\\CODING\\CSHARP\\ws1.txt";

            if (!string.IsNullOrWhiteSpace(path))
            {
                Console.WriteLine("Seems like you filled something it. Let's check if it's correct, shall we?");
                Console.ReadKey();
            }   
            if (path.Contains(".txt"))
            {
                string tekstbestand = File.ReadAllText(path);
                Console.WriteLine("The file is made out of .txt atleast.");
                File.Exists(path);
                Console.ReadKey();
                Console.WriteLine("And the source file exists! Guess you want to read the file now, huh?");
                Console.ReadKey();
                Console.WriteLine(tekstbestand);
            }

            //else if(File.Exists(path))
            //{
           // ik heb geen if else nodig lol
            //}

            else
            {
                Console.WriteLine("Seems like the file or path has been taken to another castle..");
            }
        }
       // Wordt niet om gevraagd, maar ze hebben liever een switch statement dan een if/else
       // dus bij deze, als oefening:
        static void Opdracht2Switch()
        {

            string path = "C:\\Users\\gally\\Documents\\SCHOOL\\CODING\\CSHARP\\ws1.txt";

            switch (Path.GetExtension(path))
            {
                case "":
                    Console.WriteLine("Seems like the path is empty.");
                    break;
                case ".txt" when File.Exists(path):
                    string tekstbestand = File.ReadAllText(path);
                    Console.WriteLine("The file is made out of .txt atleast.");
                    Console.ReadKey();
                    Console.WriteLine("And the source file exists! Guess you want to read the file now, huh?");
                    Console.ReadKey();
                    Console.WriteLine(tekstbestand);
                    break;
                case ".txt":
                    Console.WriteLine("The file is made out of .txt atleast.");
                    Console.ReadKey();
                    Console.WriteLine("But the file does not exist...");
                    break;
                default:
                    Console.WriteLine("Seems like the file or path has been taken to another castle..");
                    break;
            }
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