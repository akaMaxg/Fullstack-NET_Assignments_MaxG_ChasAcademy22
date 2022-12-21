using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullstack_NET_MaxG_ChasAcademy22
{
    public class Workshop4_MenuSystem
    {
        public static void MenuSystem()
        {
            //Introduktionsmeddelande
            Console.WriteLine("Välkommen till de tidigare workshopsen! " +
                "\nHär kommer du få göra ett av fyra val. ");

            //Menysträng
            string MenyText =
                "\nVar god välj ett alternativ" +
                "\n[1] My first program " +
                "\n[2] Guess a number " +
                "\n[3] Chessboard " +
                "\n[4] Avsluta";

            //Skriver ut menyn
            Console.WriteLine(MenyText);

            //Programmet körs sålänge minbool inte är false, vilket den tillsätts i Case 4 och går ur while-loopen samt progammet.
            bool MinBool = true;
            while (MinBool)
            {
                //Här anger användaren menyvalet
                int choice;
                int.TryParse(Console.ReadLine(), out choice);
                string yn = "";

                // Switch för att de olika typer av menyalternativen
                switch (choice)
                {
                    // Menyval 1 
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Du har valt 1, My first Program. Vill du fortsätta? y/n");
                        yn = Console.ReadLine();
                        if (yn == "y")
                        {
                            Workshop1_MyFirstProgram.MyFirstProgram();
                        }
                        else if (yn == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du angav ogiltigt svar, återvänder till menyn.");
                        }
                        Console.WriteLine($"" +
                                "\nHur vill du fortsätta?" +
                                $"\n {MenyText}");
                        break;

                    // Menyval 2
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Du har valt 2, Guess Game. Vill du fortsätta? y/n");
                        yn = Console.ReadLine();
                        if (yn == "y")
                        {
                            Workshop2_NumberGame.GuessGame();
                        }
                        else if (yn == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du angav ogiltigt svar, återvänder till menyn.");
                        }

                        Console.WriteLine($"" +
                                "\nHur vill du fortsätta?" +
                                $"\n {MenyText}");
                        break;

                    // Menyval 3
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Du har valt 3, Chessboard. Vill du fortsätta? y/n");
                        yn = Console.ReadLine();
                        if (yn == "y")
                        {
                            Workshop3_Chessboard.Chessboard();
                        }
                        else if (yn == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Du angav ogiltigt svar, återvänder till menyn.");
                        }
                        Console.WriteLine($"" +
                                "\nHur vill du fortsätta?" +
                                $"\n {MenyText}");
                        break;

                    // Menyval 4, sätter minbool till false, och avslutar programmet
                    case 4:
                        Console.Clear();
                        MinBool = false;
                        break;

                    //Om användaren ger en input utöver menyalternativen
                    default:
                        Console.WriteLine("Välj mellan 1-4." +
                            $"\n {MenyText}");
                        break;
                }
                //Avslutande ord då programmet avslutas
                if (MinBool == false)
                {
                    Console.Clear();
                    Console.WriteLine("Tack för engagemanget");
                    Console.ReadLine();
                }
            }
        }
    }
}

