using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullstack_NET_MaxG_ChasAcademy22
{
    public class Workshop10_Array
    {
        public static void Arrays()
        {
            Console.WriteLine("Välkommen till en smärre funktion som omvänder en array"); //Introduction
            Console.Write("Var vänlig ange hur stor array du vill ha ");
            int arraySize = int.Parse(Console.ReadLine()); //Saves a variabel passed by user as size

            Console.WriteLine("Skriv in " + arraySize + " antal heltal"); //Prompt to enter equal amount of values
            int[] array = new int[arraySize]; //Enters them in a new array, with the previously set size

            for (int k = 0; k < array.Length; k++) //Loop to enter the user inputs to the array
            {
                array[k] = int.Parse(Console.ReadLine());
            }
            Console.Write("Normal Array: "); //Loop to print array normally
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            int[] reversedArray = array; //Copies array into a new array

            Array.Reverse(reversedArray); //Reverse method on the new array
            Console.WriteLine();
            Console.Write("Reversed Array: ");
            foreach (int j in reversedArray) //Prints the reversed Array
            {
                Console.Write(j + " ");
            }
        }
    }
}
