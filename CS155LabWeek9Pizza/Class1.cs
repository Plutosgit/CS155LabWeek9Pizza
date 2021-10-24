using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS155LabWeek9Pizza
{
    class Pizza
    {
        private string size;
        private int numtoppings_cheese, numtoppings_pepperoni, numtoppings_ham;
        private double cost;

        //constructors
        public Pizza()
        {
            size = "Unknown";
            numtoppings_cheese = 0;
            numtoppings_pepperoni = 0;
            numtoppings_ham = 0;
        }

        public Pizza(string s, int c, int p, int h)
        {
            if (s.ToLower().Equals("small") || s.ToLower().Equals("medium") || s.ToLower().Equals("large"))
            { 
                size = s.ToLower();
                numtoppings_cheese = c;
                numtoppings_pepperoni = p;
                numtoppings_ham = h;

                CalculateCost();
            }
            else
            {
                Console.WriteLine("Invalid size. Pizza created with Unknown size!");
                size = "Unknown";
                numtoppings_cheese = 0;
                numtoppings_pepperoni = 0;
                numtoppings_ham = 0;
            }
        }

        //public int Count { get => count; set => count = value; } //  was removed since problem statement says "There shoud be no input method or other setter methods. The only method that can set the counter is the one that sets it to 0."
        public string Size { get => size; set => size = value.ToLower(); }
        public int CheeseToppings { get => numtoppings_cheese; set => numtoppings_cheese = value; }
        public int PepperoniToppings { get => numtoppings_pepperoni; set => numtoppings_pepperoni = value; }
        public int HamToppings { get => numtoppings_ham; set => numtoppings_ham = value; }

        public double CalculateCost()
        {   
            //calculate cost of toppings 
            double costofToppings = 2.0 * (numtoppings_cheese + numtoppings_pepperoni + numtoppings_ham);

            //First calculate cost by size of the pizza
            switch (size)
            {
                case "small":
                    cost = 10.0 + costofToppings;
                    break;

                case "medium":
                    cost = 14.0 + costofToppings;
                    break;

                case "large":
                    cost = 16.0 + costofToppings;
                    break;

                default:
                    cost = 0.0;
                    break;
            }

            return cost;
        }

        override public string  ToString()
        {
            string s = "Pizza:    Size = " + this.Size  +", Cost of Pizza = " + cost.ToString("C") + "\n" + "Cheese toppings = " + this.CheeseToppings + ", Pepperoni toppings = " + this.PepperoniToppings
                + ", Ham toppings = " + this.HamToppings  + "\n";
            return s;
        }
    }
}
