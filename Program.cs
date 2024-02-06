using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Schneckerennen2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 55);
            Rennschnecke mike = new Rennschnecke("Mike", 4);
            Rennschnecke alice = new Rennschnecke("Alice", 5);
            Rennschnecke lilith = new Rennschnecke("Lilith", 5);
            Rennschnecke jack = new Rennschnecke("Jack", 4);
            Rennschnecke judith = new Rennschnecke("Judith", 5);
            Rennschnecke joe = new Rennschnecke("Joe", 4);
            Rennschnecke slick = new Rennschnecke("Slick", 5);

            Rennen grandTour = new Rennen("Grand Tour", 7, 40);

            grandTour.AddRennschnecke(mike);
            grandTour.AddRennschnecke(alice);
            grandTour.AddRennschnecke(lilith);
            grandTour.AddRennschnecke(jack);
            grandTour.AddRennschnecke(judith);
            grandTour.AddRennschnecke(joe);
            grandTour.AddRennschnecke(slick);
            grandTour.Ausgabe();
            
            grandTour.Ausgabe();

            Wettbüro wtb = new Wettbüro(grandTour, 4);

            wtb.WetteAnnehmen("Alice", 40, "Livia");
            wtb.WetteAnnehmen("Lilith", 30, "Robert");
            wtb.WetteAnnehmen("Jack", 25, "John");
            wtb.WetteAnnehmen("Mike", -25, "Gertrude");
            wtb.WetteAnnehmen("Judith", 100, "Rafael");
            wtb.WetteAnnehmen("joe", -15, "Livia");
            wtb.WetteAnnehmen("slick", 20, "John");

            //wtb.RennAblauf();
            wtb.Ausgabe();

            Console.Clear();
            Console.WriteLine("\x1b[3J");

            while (grandTour.ErmittleGewinner() == null)
            {
                grandTour.PrintRaceAnimation1();
                wtb.PrintWette();
                Thread.Sleep(1000);
                grandTour.PrintRaceAnimation2();
                wtb.PrintWette();
                Thread.Sleep(400);
                grandTour.LasseSchneckenKriechen();
                grandTour.PrintRaceAnimation2();
                wtb.PrintWette();
                Thread.Sleep(400);
            }
            Console.SetCursorPosition(0, 28);
            Console.ReadKey();




        }



    }
}
