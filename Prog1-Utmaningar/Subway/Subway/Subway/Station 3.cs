using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class Station_3
    {
        public string Input3  // property/egenskap/GETTER, låter mig hämta en privat variabel i en annan klass.
        {
            get { return input; }
        }

        string input = "";
        //Jag gör en Konstruktor.
        public Station_3()
        {
        }
        public string S3_Logik()
        {
            // Jag förklarar för användaren vilka kommandon som fungerar.
            Console.WriteLine("Speakers: Welcome to Subwaystation 'Three'");
            redo:
            Console.Write("Do you want to board the train to Subwaystation 'Two'? y/n: ");
            input = Console.ReadLine();
            // Jag kollar inputten som användaren skickar in och returenar det, så länge det är an valid input.
            if (input == "y")
            {
                Console.WriteLine("You are now leaving Subwaystation 'Three'");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                return input;
            }
            else if (input == "n")
            {
                Console.WriteLine("You left at Subwaystation 'Three'");
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
