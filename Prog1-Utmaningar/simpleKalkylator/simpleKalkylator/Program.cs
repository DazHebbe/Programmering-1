using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleKalkylator
{
    class Program
    //Erik Herbertsson
    {
        static void Main(string[] args)
        {
            Top:
            // Jag skapar tre Integers för att hålla mina tal när jag har konverterat dem.
            int nn, ww, aa;
            // Jag skriver ut all text för att förklara vad man ska göra.
            Console.WriteLine("Simpel Kalkylator");
            Console.WriteLine("Välj vilket räknesätt du ska använda");
            Console.WriteLine("Räknesätt: ");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraktion");
            Console.WriteLine("3: Multiplikation");
            
            
            
            // Jag skriver ut text och får koden att sen läsa vad användaren skriver in.
            Console.Write("Ditt Val: ");
            string n = (Console.ReadLine());


            Console.Write("Tal 1: ");
            string w = (Console.ReadLine());


            Console.Write("Tal 2: ");
            string a = (Console.ReadLine());

            // Koden kollar om texten som skrevs in är siffror
            bool resultat1 = int.TryParse(n, out nn);
            bool resultat2 = int.TryParse(w, out ww);
            bool resultat3 = int.TryParse(a, out aa);







            // Om alla insatta siffror är nummer, kör programmet.
            if (resultat1 && resultat2 && resultat3)
            {
                //Om nn är 1 kör plussa ww med aa.
                if (nn == 1)
                {
                    Console.Write("Summan av {0} Plus {1} Är: {2}", ww, aa, ww + aa);
                }
                //annars om nn är 2 ww minus aa.
                else if (nn == 2)
                {
                    Console.Write("Summan av {0} Minus {1} Är: {2}", ww, aa, ww - aa);
                }
                // annars of nn är 3 gångra ww med aa.
                else if (nn == 3)
                {
                    Console.Write("Summan av {0} Gånger {1} Är: {2}", ww, aa, ww * aa);
                }
            }
            // annars förklara att användaren har skrivit fel nummer och kör om programmet.
            else
            {
                Console.WriteLine("Du kan bara skriva in ett nummer, och det får inte vara för stort!");
                Console.WriteLine();
                goto Top;
            }




            // Om programmet kommer till botten så säg att användaren kan trycka ENTER för att stänga programmet.
            Console.WriteLine();
            Console.WriteLine("Tryck ENTER För Att Stänga Programmet");
            Console.ReadLine();
        }
    }
}
