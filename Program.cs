namespace Fullstack_NET_MaxG_ChasAcademy22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome + User input
            Console.WriteLine("This program holds every assignment in C# course.\nPlease select which program you would like to run.");
            bool runMenu = true;

            while (runMenu)
            {
                Console.WriteLine("\nChoose a program:\n" +
                    "   1.  Place_holder\n" +
                    "   2.  Login_Objects\n" +
                    "   3.  Arrays\n" +
                    "   4.  OOP_Polymorphism\n" +
                    "   5.  OOP_Inherit\n" +
                    "   6.  OOP_Class\n" +
                    "   7.  FizzBUzz\n" +
                    "   8.  RockPaperScissors\n" +
                    "   9.  MenuSystem\n" +
                    "   10. Checkboard\n" +
                    "   11. Numbers game\n" +
                    "   12. My first program\n" +
                    "   Exit program");
                Console.WriteLine("");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();

                        break;
                    case "2":
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    case "7":
                        Console.Clear();
                        Workshop6_FizzBuzz.FizzBuzzer();
                        break;
                    case "8":
                        Console.Clear();
                        Workshop5_RockPaperScissors.RockPaperScissors();
                        break;
                    case "9":
                        Console.Clear();
                        Workshop4_MenuSystem.MenuSystem();
                        break;
                    case "10":
                        Console.Clear();
                        Workshop3_Chessboard.Chessboard();
                        break;
                    case "11":
                        Console.Clear();
                        Workshop2_NumberGame.GuessGame();
                        break;
                    case "12":
                        Console.Clear();
                        Workshop1_MyFirstProgram.MyFirstProgram();
                        break;
                    case "13":
                        Console.Clear();
                        runMenu = false;
                        break;
                    default:
                        runMenu = false;
                        break;
                }
                Console.WriteLine("Thank you for stopping by.");
            }
        }
    }
}