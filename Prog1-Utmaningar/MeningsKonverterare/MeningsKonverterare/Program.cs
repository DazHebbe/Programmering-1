using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeningsKonverterare
{
    class Program
        //Erik Herbertsson
    {
        static void Main(string[] args)
        {
            Top:
            Console.WriteLine();
            // Tilldela dg som en integer.
            int dg;
            // Skriv text som förklarar för användaren ved de ska göra.
            Console.WriteLine("Meningskonverterare");
            Console.WriteLine("Välj 1 för att konvertera till stora bokstäver");
            Console.WriteLine("Välj 2 för att konvertera till små bokstäver");

            Console.Write("Ditt val: ");

            string d = (Console.ReadLine());
            // Kolla så att användaren skrev in ett nummer.
            bool resultat1 = int.TryParse(d, out dg);
            // Om användaren skrev in ett nummer, kör programmet.
            if (resultat1)
            {
                //Om dg är 1 kör detta program.
                if (dg == 1)
                {
                    //Konvertera användarens insatta mening till stora bokstäver och skriv ut.
                    Console.Write("Din Mening: ");
                    string g = Console.ReadLine().ToUpper();
                    Console.Write("Konverterad mening: ");
                    Console.WriteLine(g);
                }
                //Annars om dg är 2 kör det här programmet.
                else if (dg == 2)
                {
                    // Konverter användares insatta mening till små bokstäver och skriv ut.
                    Console.Write("Din Mening: ");
                    string g = Console.ReadLine().ToLower();
                    Console.Write("Konverterad mening: ");
                    Console.WriteLine(g);
                }
                //Annars förklara att användaren skrev in ett felaktigt tal och kör om programmet.
                else
                {
                    Console.WriteLine("Dina val är 1 eller 2!");
                    goto Top;
                }
            }
            //Annars förklara att användaren inte skrev in ett tal och kör om programmet.
            else
            {
                Console.WriteLine("Dina val är 1 eller 2!");
                goto Top;
            }
            //När programmet har kommit ner hit så förklara för användaren att de kan trycka ENTER för att stänga programmet.
            Console.WriteLine("Tryck ENTER för att stänga av programmet");
            Console.ReadLine();
        }
    }
}
