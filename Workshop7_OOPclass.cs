using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullstack_NET_MaxG_ChasAcademy22
{
    public class Workshop7_OOPclass
    {
        public static void OOPclass()
        {
            {
                //Creates 2 instances of circle with varying sizes
                Circle oopRadiusFive = new Circle(5);
                Circle oopRadiusSix = new Circle(6);
                //Runs GetArea on both.
                Console.WriteLine("Area of circle with diamater 5 is " + oopRadiusFive.GetArea() + "\nArea of circle with diameter 6 is " + oopRadiusSix.GetArea());
            }
        }
        public class Circle //Class circle with 2 properties
        {
            int _radius;
            float _pi = 3.14f;

            public Circle(int Radius) //Constructor which takes 1 parameter
            {
                this._radius = Radius;
            }
            public float GetArea() //Method that calculates Area of circle
            {
                return _radius * _radius * _pi;

            }
        }
    }
}
