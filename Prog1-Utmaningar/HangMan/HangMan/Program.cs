using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {
        // Jag lägger till alla variabler som ska kommas åt överallt här.
        static char[] correctWord;
        static char[] guessWord;
        static char nn;
        static char nn1;
        static char nn2;
        static char nn3;
        static int chanser = 5;

        static void Main(string[] args)
        {
            Console.WriteLine("THE GAME OF HANGMAN!");
            // Jag kallar på min RNG Metod som drar fram ett utav ordena jag har i den.
            RNG();

            
            //Jag skriver ut längden utav mitt ord i streck.
            for (int i = 0; i < guessWord.Length; i++)
            {
                guessWord[i] = '_';
            }

            foreach (char c in guessWord)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            //Jag kör min huvudmetod.
            userInput();


            Console.WriteLine("Game Over!");

            Console.ReadLine();
        }




        public static void RNG()
        {
            //Jag tilldelar ord till varje position i arrayen.
            string[] r = new string[7];
            r[0] = "dine";
            r[1] = "book";
            r[2] = "read";
            r[3] = "life";
            r[4] = "dead";
            r[5] = "star";
            r[6] = "wars";

            //Jag väljer ett utav ordena genom en Random.
            Random rng = new Random();
            string ord = r[rng.Next(0, r.Length)];

            //Jag gör varje bokstav i mitt ord till en egen char.
            correctWord = ord.ToCharArray();
            guessWord = new char[correctWord.Length];
        }




        public static void userInput()
        {
            //Jag kollar vad användaren skriver in och jämför det med första bokstaven i det rätta ordet.
            again0:
            Console.Write("Your Guess: ");
            string n = Console.ReadLine();
            bool resultat1 = char.TryParse(n, out nn);
            if (chanser > 0 && nn == correctWord[0])
            {
                again1:
                Console.Write($"{nn} ");
                for (int i = 0; i < guessWord.Length - 1; i++)
                {
                    Console.Write("_ ");
                }
                Console.WriteLine();
                //Jag kollar vad användaren skriver in och jämför det med andra bokstaven i det rätta ordet.
                Console.Write("Your Guess: ");
                string n1 = Console.ReadLine();
                bool resultat2 = char.TryParse(n1, out nn1);

                if (chanser > 0 && nn1 == correctWord[1])
                {
                    again2:
                    Console.Write($"{nn} {nn1} ");
                    for (int i = 0; i < guessWord.Length - 2; i++)
                    {
                        Console.Write("_ ");
                    }
                    Console.WriteLine();
                    //Jag kollar vad användaren skriver in och jämför det med tredje bokstaven i det rätta ordet.
                    Console.Write("Your Guess: ");
                    string n2 = Console.ReadLine();
                    bool resultat3 = char.TryParse(n2, out nn2);

                    if (chanser > 0 && nn2 == correctWord[2])
                    {
                        again3:
                        Console.Write($"{nn} {nn1} {nn2}");
                        for (int i = 0; i < guessWord.Length - 3; i++)
                        {
                            Console.Write("_ ");
                        }
                        Console.WriteLine();
                        //Jag kollar vad användaren skriver in och jämför det med fjärde bokstaven i det rätta ordet.
                        Console.Write("Your Guess: ");
                        string n3 = Console.ReadLine();
                        bool resultat4 = char.TryParse(n3, out nn3);

                        if (chanser > 0 && nn3 == correctWord[3])
                        {
                            Console.Write($"{nn} {nn1} {nn2} {nn3}");
                            for (int i = 0; i < guessWord.Length - 4; i++)
                            {
                                Console.Write("_ ");
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            chanser--;
                            Console.WriteLine($"Wrong! You got: {chanser} chances left! ");
                            goto again3;
                        }
                    }
                    else
                    {
                        chanser--;
                        Console.WriteLine($"Wrong! You got: {chanser} chances left! ");
                        goto again2;
                    }
                }
                else
                {
                    chanser--;
                    Console.WriteLine($"Wrong! You got: {chanser} chances left! ");
                    goto again1;
                }
            }
            else
            {
                chanser--;
                Console.WriteLine($"Wrong! You got: {chanser} chances left! ");
                goto again0;
            }
        }


    }
}