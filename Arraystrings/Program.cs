using System;
using System.Collections.Generic;

namespace Arraystrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Cars = new string[] {"BMW","Ford","Honda","Audi" };
            Console.WriteLine("Select your model by entering the number!");
            Console.WriteLine("BMW[0], Ford[1], Honda[2], Audi[3]");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Cars[index]);
            // Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen
            int[] Cost = new int[] {200, 300, 400, 500 };
            Console.WriteLine("Select the price range! 200[0], 300[1], 400[2], 500[3] ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Cost[price]);
            if (Cost.Contains(price))
                Console.WriteLine("It's in the array");
            else
                Console.WriteLine("It's not in the array");

        }
    }
}
