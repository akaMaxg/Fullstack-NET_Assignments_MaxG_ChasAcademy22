using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullstack_NET_MaxG_ChasAcademy22
{
    public class Workshop9_OOPpolymorphism
    {
        public static void OOPpolymorphism()
        {
            var rec = new Rectangle(Math.PI, 6); //Creates new rectangle instance
            double areaRec = rec.Area(rec.sSide, rec.lSide); //Runs Area for rectangle and sets it to areaRec

            var sq = new Square(6); //New square instance
            double areaSq = sq.Area(sq.side, 0); //runs Area for square and saves output

            var circ = new Circle(5); //New circle instance
            double areaCirc = circ.Area(circ.radius, 0); //Runs Area method for circle and saves output


            //Prints the results
            Console.WriteLine("Area rectangle with one side: " + rec.sSide + " and other side: " + rec.lSide + "\nArea is: " + areaRec);
            Console.WriteLine();
            Console.WriteLine("Area square with side: " + sq.side + "\nArea is: " + areaSq);
            Console.WriteLine();
            Console.WriteLine("Area circle with radius: " + circ.radius + "\nArea is: " + areaCirc);
            Console.ReadKey();
        }
    }
    public class Geometry //Parentclass Geomtry
    {
        public virtual double Area(double a, double b) //Method, 2 parameters returns a double.
        {
            Console.WriteLine("Här räknas arean ut");
            return a * b;
        }
    }
    public class Rectangle : Geometry //Subclass to Geomotry with two properties
    {
        public double lSide { get; set; } //long side
        public double sSide { get; set; } //short side

        public Rectangle(double ShortSide, double LongSide) //Constructor for rectangle, 2 parameters
        {
            lSide = LongSide;
            sSide = ShortSide;
        }
        public override double Area(double x, double y) //overrides Area method, still 2 parameters but different calculation
        {
            return x * y;
        }
    }
    public class Square : Geometry //Subclass for square
    {
        public double side { get; set; } //Property for side

        public Square(double Side) //Constructor for side with 1 parameter
        {
            side = Side;
        }
        public override double Area(double x, double y) //Overridden method for Area
        {
            return x * x;
        }

    }
    public class Circle : Geometry //Subclass for circle
    {
        public double radius { get; set; } //Proprety for radius

        public Circle(double Radius) //Constructor with 1 parameter for radius
        {
            radius = Radius;
        }
        public override double Area(double x, double y) //Overriden method to calculate circle area.
        {
            return Math.PI * (x * x);
        }
    }
}
