using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS155LabWeek9Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Pizza objects for testers
            Console.WriteLine("Hello! Lab - Week 9 - Pizza class");
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("Creating 2 pizza objects, 1 with default constructor and 1 with user constructor");
            Console.WriteLine();

            Pizza a = new Pizza();
            Pizza b = new Pizza("medium", 2, 3, 4);

            Console.WriteLine("Calculating cost for the 2 pizza objects");
            Console.WriteLine("Cost of pizza A: $ " + a.CalculateCost().ToString());
            Console.WriteLine("Cost of pizza B: $ " + b.CalculateCost().ToString());

            Console.WriteLine(); 
            Console.WriteLine("Showing Pizza A's overridden ToString method");
            Console.WriteLine(a);
            Console.WriteLine("Showing Pizza B's overridden ToString method");
            Console.WriteLine(b);

            Console.WriteLine();
            Console.WriteLine("Changing Pizza A's size and toppings");
            a.Size = "Large";   //L should work, since it will be converted to lowercase in the setter
            a.CheeseToppings = 1;
            a.PepperoniToppings = 2;
            a.HamToppings = 3;
            a.CalculateCost();
            Console.WriteLine("Showing Pizza A after resetting its size & toppings");
            Console.WriteLine(a);

            Console.WriteLine();
            Console.WriteLine("Trying to create a pizza with incorrect size 'X'..");
            Pizza c = new Pizza("X", 1, 2, 3);
            Console.WriteLine("\nEnd of testing pizzas!");

            Console.Read();
        }
    }
}
