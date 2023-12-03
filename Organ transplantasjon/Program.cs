using Organ_transplantasjon;

namespace Organ
{
    class Program
    {
        static void Main()
        {
            bool playAgain = true;
            var Kåre = new pasienter("Kåre", 34);
            var Bjarne = new pasienter("Bjarne", 37);
            while (playAgain)
            {
            Random num = new Random();
            int chances = num.Next(1,101);
            int survival = num.Next(1,101);

            Console.WriteLine($"overlevelse med {chances}");
            Console.WriteLine($"Ikke overlevelse med {survival}");

            if (chances >= survival)
            {
                Console.WriteLine("Bjarne overlevde transplantasjonen");
            }
            else
            {
                Console.WriteLine("Bjarne overlevde ikke");
            }

            Console.WriteLine("Trykk ja/nei for å prøve igjen!");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "JA")
            {
                Console.WriteLine("La oss prøve igjen!");
            }
            else if (answer == "NEI")
            {
                Console.WriteLine("Vi sees!");
                playAgain = false;
                break;
            }
            else
            {
                Console.WriteLine("Feil inntast!");
                playAgain = false;
                break;
            }
        }
        }
    }
}
