using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullstack_NET_MaxG_ChasAcademy22
{
    public class Workshop8_OOPinherit
    {
        public static void OOPinherit()
        {
            //Create new instances of a selection of animals, using constructor where applicable
            var s = new Snake();
            var g = new Gorilla();
            var c = new Cheetah(2000);


            //Printing specific properties from the various animals and also runs methods specific to them.
            Console.WriteLine("Following are some information about the snake:");
            Console.Write(s.colour + ", " + s.climb + ", " + s.owner + ", and makes the sound ");
            s.makeSound();
            Console.WriteLine();
            Console.WriteLine("Following are some information about the Gorilla:");
            Console.Write(g.colour + ", " + g.speed + ", " + g.range + ", and makes the sound ");
            g.makeSound();
            Console.Write("Apperently the Gorilla's not very friendly and the ");
            g.Bonk();
            Console.WriteLine();
            Console.WriteLine("Following are some information about the Cheetah:");
            Console.Write(c.colour + ", " + c.speed + ", " + c.patterns + ", and makes the sound ");
            c.makeSound();
            c.Leap();

            //Instansiated a new type of Gorilla, changes properties and ran method.
            Console.WriteLine();
            var gTwo = new Gorilla();
            gTwo.str = 100;
            gTwo.Bonk();


            Console.ReadLine();

        }
    }
    public class Animals //Parent class with 5 properties and 4 methods.
    {
        public int str { get; set; }
        public int health { get; set; }
        public string colour { get; set; }
        public int speed { get; set; }
        public string owner { get; set; }

        public void Eat()
        {
            Console.WriteLine("Animal starts eating");
        }
        public void Sleep()
        {
            Console.WriteLine("Animal starts sleeping");
        }
        public void Play()
        {
            Console.WriteLine("Animal starts playing");
        }
        public virtual void makeSound()
        {
            Console.WriteLine("rawr?");
        }
    }
    public class Cheetah : Animals //Sub class with a constructor, hardcoded stats except for speed which is not inherited.
    {
        public Cheetah(int Speed)
        {
            str = 2;
            health = 10;
            colour = "yellow";
            speed = Speed;
            owner = "Kolmården";
            patterns = "Dotted";
        }
        public string patterns { get; set; } //Non-inherited property
        public void Leap() //Non inherited method
        {
            Console.WriteLine("Cheetah leaps");
        }

        public override void makeSound() //inherited overriden method
        {
            Console.WriteLine("Meow");
        }
    }
    public class Snake : Animals //Sub class with a constructor, hardcoded stats. 
    {
        public Snake()
        { //inherited stats
            str = 1;
            health = 5;
            colour = "green";
            speed = 8;
            owner = "Kolmården";
            climb = 10;
        }
        public int climb { get; set; } //Non-inherited property
        public void dash() //NOn-inherited method
        {
            Console.WriteLine("Snake dashes");
        }
        public override void makeSound() //Inherited overriden method
        {
            Console.WriteLine("Zzzttt");
        }
    }
    public class Ape : Animals //Sub class with a constructor, hardcoded stats. 
    {
        public Ape()
        { //Inherited stats
            str = 10;
            health = 20;
            colour = "brown";
            speed = 15;
            owner = "Kolmården";
            range = 10;
        }
        public int range { get; set; } //non-inherited property
        public void Throw() //non-inherited method
        {
            Console.WriteLine("Ape Throws with str: " + str);
        }

        public override void makeSound() //inherited overriden method
        {
            Console.WriteLine("Roar");
        }
    }

    public class Orangutang : Ape //Sub-sub class to 
    {
        public void Slap() //non-inherited method
        {
            Console.WriteLine("Orangutang slaps with a stick for: " + str * 2);
        }
    }

    public class Gorilla : Ape //Sub-sub class to 
    {
        public void Bonk() //Non-inherited method
        {
            Console.WriteLine("Gorilla bonks with a rock for: " + str * 5);
        }
    }
}

