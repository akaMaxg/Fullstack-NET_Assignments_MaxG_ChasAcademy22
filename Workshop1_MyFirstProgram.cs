using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullstack_NET_MaxG_ChasAcademy22
{
    public class Workshop1_MyFirstProgram
    {
            public static void MyFirstProgram()
            {
                //Deklarerar variabel
                int number = 10;
                //Kollar om siffran > 10, ger svar beroende på
                if (number > 10)
                {
                    Console.WriteLine("Talet är för stort!");
                }
                else Console.WriteLine("Oj. Lågt tal!");

                //Tar namn som input i variabel userName
                Console.WriteLine("Vad heter du?");
                string userName = Console.ReadLine();
                //Hälsar användaren välkommen
                Console.WriteLine("Hej " + userName + "!");

                //A loop that counts from 0-number, which is 10.
                for (int i = 0; i <= number; i++)
                {
                    Console.WriteLine("Skriver ut " + i);
                }
            }
        }
    }
