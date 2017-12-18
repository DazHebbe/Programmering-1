using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utmaning_1
{
    class Program
    { //Erik Herbertsson
        static void Main(string[] args)
        {
            // Jag gör en Integer med definitionen n.
            int  n;
            // Jag säger åt konsollen att skriva det under.
            Console.WriteLine("Multiplikationstabeller");
            Console.Write("Skriv in ett valfritt heltal: ");
            // Jag säger åt konsollen att konvertera alla mina n till Integer32
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            Console.Write("\n");
            //Jag gör en For Loop som Gångrar n med j och ger ut resultatet  Bracketserna gör så att jag kan
            // implementera mina tal i meningen.
            for (int j = 0; j <= 10; j++)
            {
                Console.Write("{0} Gånger {1} Är lika med: {2} \n", n, j, n * j);
            }
            Console.WriteLine("-------------------------------------");


            Console.ReadLine();
        }
    }
}
