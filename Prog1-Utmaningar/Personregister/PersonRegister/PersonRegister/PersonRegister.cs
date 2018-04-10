using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegister
{
    class PersonRegister
    {
        // Jag skapar en lista för mina personer.
        List<Person> personLista;

        // Jag gör en konstruktor för min klass.
        public PersonRegister()
        {
            personLista = new List<Person>();
        }

        // Jag skapar en metod för att lägga till personer i listan.
        public void AddPerson(string name, int age, string city)
        {


            foreach (Person person in personLista)
            {
                if (person.Name == name)
                {
                    return;
                }
            }

            personLista.Add(new Person(name, age, city));
        }

        // Jag gör en funktion för att skriva ut alla personerna i listan.
        public string GetPersons()
        {
            string persons = "";

            foreach (Person person in personLista)
            {
                persons += person.Name + "\n";
            }

            return persons;
        }

        // Jag gör en metod för att lägga till mina standardpersoner.
        public void AddStandard()
        {
            Person nicklas = new Person("Nicklas", 32, "Hofors");
            Person sebastian = new Person("Sebastian", 20, "Hofors");
            Person becky = new Person("Becky", 21, "Falun");

            personLista.Add(nicklas);
            personLista.Add(sebastian);
            personLista.Add(becky);


        }

        // Jag gör en metod för att skriva ut en specific person till konsollen.
        public string SpecificPerson(string input)
        {
            string p = "";

            foreach (Person person in personLista)
            {
                if (person.Name == input)
                    p = person.printPerson();
                else
                {
                    Console.WriteLine("ERROR! Felaktig input!");
                }
            }

            return p;
        }
    }
}