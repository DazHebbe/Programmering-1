using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class Station_2
    {
        public string Input2  // property/egenskap/GETTER, låter mig hämta en privat variabel i en annan klass.
        {
            get { return input; }
        }

        string input = "";
        //Jag gör en Konstruktor.
        public Station_2()
        {
        }
        public string S2_Logik()
        {
            // Jag skriver ut för användaren vilka kommandon som fungerar.
            Console.WriteLine("Speakers: Welcome to Subwaystation 'Two'");
            redo:

            Console.WriteLine("You see two trains... ");
            Console.WriteLine("Go to Subwaystation 'One': 1");
            Console.WriteLine("Go to Subwaystation 'Three': 2");
            Console.WriteLine("Leave the subway: 3");
            Console.Write("Your choice: ");
            input = Console.ReadLine();
            // Jag kollar inputten som användaren skickar in och returenar det så länge det är en valid input.
            if (input == "1")
            {
                Console.WriteLine("You are now leaving Subwaystation 'Two'");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
                return input;
            }
            else if (input == "2")
            {
                Console.WriteLine("You are now leaving Subwaystation 'Two'");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
                return input;
            }
            else if (input == "3")
            {
                Console.WriteLine("You left at Subwaystation 'Two'");
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
