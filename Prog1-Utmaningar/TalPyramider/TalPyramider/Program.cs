using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalPyramider
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jag skapar en Integer för att hålla mitt out-tal
            int dg;
            Console.Write("Skriv in ett tal: ");
            //Jag tar ett input och kollar så att det är ett tal
            string d = Console.ReadLine();
            bool resultat1 = int.TryParse(d, out dg);
            if (resultat1)
            {
                //Jag loopar antal gånger som sätts in i konsollen
                for (int i = 1; i <= dg; i++)
                {
                    //Jag gör samma sak här men med i istället för talet som vart insatt i konsollen
                    for (int r = 1; r <= i; r++)
                    {
                        //Jag skriver det talet som sats in i konsollen
                        Console.Write(dg);
                    }
                    //Jag hoppar ner en rad för att skriva nästa bit av kod
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Du skrev in ett felaktigt tecken!");
            }
            Console.WriteLine("Tryck ENTER för att stänga av programmet");
            Console.ReadLine();
        }
    }
}
