using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullstack_NET_MaxG_ChasAcademy22
{
    public class Workshop6_FizzBuzz
    {
        public static void FizzBuzzer()
        {
            Console.Write("Välkommen till Fizzbuzz. \nAnge en siffra: "); //Introduktion
            int input;
            int.TryParse(Console.ReadLine(), out input); //Parse för int
            Console.WriteLine($"Du har angett {input}, Fizzbuzz startar... \n"); //Startprompt



            //For loop kör igenom alla värden upp tom inputen.

            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 && i % 5 != 0) //Om delbar med 3 men inte 5
                {
                    Console.WriteLine("Fizz"); //Skriv ut Fizz
                }
                else if (i % 5 == 0 && i % 3 != 0) //Om delbar med 5 men inte 3
                {
                    Console.WriteLine("Buzz"); //Skriv ut Buzz
                }
                else if (i % 5 == 0 && i % 3 == 0) //Om delbar med 5 och 3
                {
                    Console.WriteLine("Fizzbuzz"); //Skriv ut fizzbuzz
                }
                else
                {
                    Console.WriteLine(i); //Skriv annars ut talet

                }
            }
            Console.ReadLine();

        }
    }
}
