using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class Station_1
    {
        public string Input  // property/egenskap/GETTER, låter mig hämta en privat variabel i en annan klass.
        {
            get { return input; }
        }

        string input = "";
        //Jag gör en Konstruktor.
        public Station_1()
        {
        }
        public string S1_Logik()
        {
            // Jag förklarar för användaren vilka kommandon som fungerar.
            Console.WriteLine("Speakers: Welcome to Subwaystation 'One'");
            redo:
            Console.Write("Board the train? y/n: ");
            input = Console.ReadLine();
            // Jag kollar inputten som användaren skickar in och returenar det så länge det är en valid input.
            if (input == "y")
            {
                Console.WriteLine("You are now leaving Subwaystation 'One'");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
                return input;
            }
            else if (input == "n")
            {
                Console.WriteLine("You left at Subwaystation 'One'");
                return input;
            }
            else
            {
                Console.WriteLine("Invalid input, try again.");
                goto redo;
            }
        }
    
    }
}
