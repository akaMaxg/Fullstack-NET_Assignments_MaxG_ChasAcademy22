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
                Console.WriteLine("Choose a program:\n" +
                    "   1.  Login_Objects\n" +
                    "   2.  Arrays\n" +
                    "   3.  OOP_Polymorphism\n" +
                    "   4.  OOP_Inherit\n" +
                    "   5.  OOP_Class\n" +
                    "   6.  FizzBUzz\n" +
                    "   7.  RockPaperScissors\n" +
                    "   8.  MenuSystem\n" +
                    "   9.  Checkboard\n" +
                    "   10. Troubleshoot\n" +
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
                        break;
                    case "8":
                        Console.Clear();
                        break;
                    case "9":
                        Console.Clear();
                        break;
                    case "10":
                        Console.Clear();
                        break;
                    case "11":
                        Console.Clear();
                        break;
                    case "12":
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