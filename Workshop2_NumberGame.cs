using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullstack_NET_MaxG_ChasAcademy22
{
    public class Workshop2_NumberGame
    {
        public static void GuessGame()
        {
            Random random = new Random();
            int number = random.Next(1, 20);
            Console.WriteLine(number);

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            int guessCount = 0;
            int guess;
            while (guessCount < 5)
            {
                Console.WriteLine("Gissa på ett heltal");
                int.TryParse(Console.ReadLine(), out guess);
                if (guess == number)
                {
                    Console.WriteLine("Bravo, du gissade rätt!");
                    Console.WriteLine("Spelet är slut");
                    break;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Du Gissade för lågt!");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Du gissade för högt!");
                }
                guessCount++;
            }
            if (guessCount == 5)
            {
                Console.WriteLine("Game Over");
            }
            Console.WriteLine("Tryck på enter för att avsluta");
            Console.ReadLine();
        }
    }
}
