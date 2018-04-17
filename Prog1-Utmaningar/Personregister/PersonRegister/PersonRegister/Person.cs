using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRegister
{
    class Person
    {
        string name;
        int age;
        string city;

        public string Name  // property/egenskap/GETTER
        {
            get { return name; }
        }

        // Jag gör en mall för hur en person ska beskrivas i programmet med namn, år och stad.

        public Person(string name, int age, string city)
        {
            this.name = name;
            this.age = age;
            this.city = city;
        }

        // Jag gör en metod för att skriva ut en person, med hjälpmetoder för att det ska bli mer sorterat.
        public string printPerson()
        {
            string person = "";

            person = name;
            person += listAge();
            person += listCity();

            return person;
        }

        private string listAge()
        {
            string listedAge = "";

            listedAge = $" är {age} år ";

            return listedAge;
        }

        private string listCity()
        {
            string listedCity = "";

            listedCity = $"och bor i {city}";

            return listedCity;
        }
    }
}
