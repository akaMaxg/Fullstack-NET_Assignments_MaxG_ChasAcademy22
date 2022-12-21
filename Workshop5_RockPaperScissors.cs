using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullstack_NET_MaxG_ChasAcademy22
{
    public class Workshop5_RockPaperScissors
    {
        public static void RockPaperScissors()
        {
            //Initiate and declare variables
            int val;
            //instancing a new random type
            Random rnd = new Random();
            int pcTurn;
            int pcScore = 0;
            int playerScore = 0;

            Console.WriteLine("Välkommen till sten sax påse. \nDu spelar mot datorn och det är först till 3!");

            //For loop that keeps score
            while (pcScore < 3 && playerScore < 3)
            {
                //Randoms a number between 1-3 which will correspond to rock paper scissor
                pcTurn = rnd.Next(1, 4);
                Console.WriteLine("\nVälj en av nedanstående genom att skriva 1, 2 eller 3: \n" +
                    "[1] Sten \n" +
                    "[2] Sax \n" +
                    "[3] Påse");

                //User chooses.
                val = Int32.Parse(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        if (val != pcTurn) // Check to see if its a match and draw
                        {
                            if (val == 1 && pcTurn == 3) //If player chose 1
                            {
                                Console.WriteLine("Du förlorade med Sten\n" +
                                    "Pc:n valde Påse");
                                pcScore++; // Adds score for PC
                            }

                            if (val == 1 && pcTurn == 2)
                            {
                                Console.WriteLine("Du vann med Sten!\n" +
                                    "Pc:n valde Sax");
                                playerScore++; //Adds score for user
                            }

                        }
                        else
                        {
                            Console.WriteLine("Det blev oavgjort!"); //Tie
                        };
                        break;

                    case 2:
                        if (val != pcTurn) // Check to see if its a match and draw
                        {
                            if (val == 2 && pcTurn == 1)  //If player chose 2
                            {
                                Console.WriteLine("Du förlorade med Sax!\n" +
                                    "Pc:n valde Sten");
                                pcScore++;
                            }
                            if (val == 2 && pcTurn == 3)
                            {
                                Console.WriteLine("Du vann med Sax!\n" +
                                    "Pc:n valde Påse");
                                playerScore++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Det blev oavgjort!");
                        };
                        break;

                    case 3:
                        if (val != pcTurn) // Check to see if its a match and draw
                        {
                            if (val == 3 && pcTurn == 2) //If player chose 2
                            {
                                Console.WriteLine("Du förlorade med Påse!\n" +
                                    "Pc:n valde Sax");
                                playerScore++;
                            }

                            if (val == 3 && pcTurn == 1)
                            {
                                Console.WriteLine("Du vann med Påse!\n" +
                                    "Pc:n valde Sten");
                                pcScore++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Det blev oavgjort!");
                        };
                        break;

                    default:
                        Console.WriteLine("Ogiltigt svar");
                        break;
                }
                //Update on score after each iteration
                Console.WriteLine($"\nStällningen är\n" +
                    $"Du: {playerScore}\n" +
                    $"Datorn: {pcScore}");
            }
            //After while loop, e.g. when a player reaches 3. Check to see whom and announce winner
            if (pcScore == 3)
            {
                Console.WriteLine($"Spelet är slut Pc:n vann med {pcScore} - {playerScore}!");
            }
            else
            {
                Console.WriteLine($"Spelet är slut du vann med {playerScore} - {pcScore}!");
            }
        }
    }
}

