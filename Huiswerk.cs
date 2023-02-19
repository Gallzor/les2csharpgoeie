using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2
{
    public class Huiswerk
    {
        //hier zijn de opdrachten alleen beschikbaar voor de class zelf.
    }

    public class Fiets
    {
        public enum Kleur 
        { 
            Blauw, 
            Rood, 
            Oranje,
            Geel, 
            Groen 
        }
        public enum Bel 
        { 
            Ja, 
            Nee, 
            Onbekend 
        }

        public enum FietsNaam
        {
            Gazelle,
            Batavus,
            Sparta
        }

        //autocreated methode:
        public Kleur Fietskleur { get; set; }
        public Bel Fietsbel { get; set; }
        public FietsNaam Fietstype { get; set; }
        public int Framehoogte { get; set; }

        public void Print()
        {
            Console.WriteLine($"De type fiets is een {Fietstype}. \n De kleur is {Fietskleur}. \n Heeft de fiets een bel: {Fietsbel}. \n De framehoogte is {Framehoogte}. \n");
        }
    }
}
