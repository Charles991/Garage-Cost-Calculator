using System;

namespace Garage_cost_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables;
            int numOftyres;
            string typeOftyres;
            decimal tyrePrice;
            decimal tyreTotal;
            string exaust;
            
            
            Console.WriteLine("How many tyres do you require?");
            numOftyres = int.Parse(Console.ReadLine());

            Console.WriteLine("If you want budget tyres please enter b and if you want premium tyres please enter p");
            typeOftyres = Console.ReadLine();
           
            if (typeOftyres == "b")
            { tyrePrice = 29.99M; }
            else
            { tyrePrice = 49.99M; }

            tyreTotal = tyrePrice * numOftyres;
            if (numOftyres >=4)
            { tyreTotal = tyreTotal * 0.8M; }

            Console.WriteLine("Do you want an exhaust? Please enter y for yes or n for no");
            exaust = Console.ReadLine();
            if (exaust == "y")
            { tyreTotal = (tyreTotal + 69.99M) - 10M; }

            Console.Write("Your total price is " + tyreTotal);





           
        }
    }
}
