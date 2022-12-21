using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullstack_NET_MaxG_ChasAcademy22
{
    public class Workshop3_Chessboard
    {
        public static void Chessboard()
        {
            //Introduction
            Console.WriteLine("Hej, välkommen till Checkboard, ange dimensionen av rutnätet med en siffra.");

            //Variables
            int cr;
            //Convert string to int
            int.TryParse(Console.ReadLine(), out cr);
            string b = "X";
            string w = "O";
            string fRow = "";
            string sRow = "";

            //Since 2 rows alternate, following for loop dictates first row
            for (int i = 0; i < cr; i++)
            {
                if (i % 2 == 0)
                {
                    fRow = fRow + w;
                }
                else
                {
                    fRow = fRow + b;
                }
            }

            //Following for loop dictates second row
            for (int j = 0; j < cr; j++)
            {
                if (j % 2 != 0)
                {
                    sRow = sRow + w;
                }
                else
                {
                    sRow = sRow + b;
                }
            }

            //Post alternating first and second row
            for (int f = 0; f < cr; f++)
            {
                if (f % 2 == 0)
                {
                    Console.WriteLine(fRow);
                }
                else
                {
                    Console.WriteLine(sRow);
                }
            }
            Console.ReadLine();
        }
    }
}
