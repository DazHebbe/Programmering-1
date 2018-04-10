using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegister
{
    class Logik
    {
        string name;

        int age;

        string city;

        string input;

        // Jag gör en instans av PersonRegister så att jag kan använda dens funktioner.
        PersonRegister InstanceOfPR = new PersonRegister();
        
        // Jag gör en startmetod för att få mitt program att gå igång.
        public void Start()
        {

            InstanceOfPR.AddStandard();

            Console.WriteLine("Personregister: ");

            MenuText();

            // Jag gör en loop för att min kod inte ska stängas ner.

            while (input != "0")
            {
                Reader();

                MainLogic();
            }
        }

        // Jag gör en metod för att hålla all min huvudlogik.

        public void MainLogic()
        {

            switch (input)
            {
                case "1":

                    Console.WriteLine(InstanceOfPR.GetPersons());

                    break;

                case "2":

                    Console.Write("Namn: ");
                    name = Console.ReadLine();

                    Console.Write("Ålder: ");
                    age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Stad: ");
                    city = Console.ReadLine();


                    InstanceOfPR.AddPerson(name, age, city);

                    break;

                case "meny":
                    MenuText();

                    break;

                default:

                    // Om inputten inte är lika som alla cases så jämför jag inputten med alla personers namn och skriver ut ders information om inputten matchar.

                    Console.WriteLine(InstanceOfPR.SpecificPerson(input));

                    break;
            }
        }

        public void MenuText()
        {
            Console.WriteLine("\nDina val: ");
            Console.WriteLine("Tryck 1 för att se personerna i listan");
            Console.WriteLine("Tryck 2 för att lägga till en person");
            Console.WriteLine("Skriv namn på en befintlig person för att få mer information");
            Console.WriteLine("Skriv 'meny' för att få se menyn igen");
            Console.WriteLine("Tryck 0 för att avsluta\n");

        }

        public void Reader()
        {
            Console.Write("Ditt val: ");

            input = Console.ReadLine();
        }
    }
}
