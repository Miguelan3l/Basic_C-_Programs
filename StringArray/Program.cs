using System;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Cars = new string[] { "BMW", "Ford", "Honda", "Audi" };
            Console.WriteLine("Select your model by entering the number!");
            Console.WriteLine("BMW[0], Ford[1], Honda[2], Audi[3]");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Cars[index]);
            // Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen
            int[] Cost = new int[] { 200, 300, 400, 500 };
            Console.WriteLine("Select the price range! 200[0], 300[1], 400[2], 500[3] ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Cost[price]);
            // create a array and display a message if the array is not avalible 

            int[] validValues = {100, 200, 400, 500 };


            Console.WriteLine("100, 200, 400, 500");
            Console.WriteLine("Enter a order number, program will let you know if it is in stock or not");
            int ordernumber = int.Parse(Console.ReadLine());
            bool itemInStock = false;
            for (int i = 0; i < validValues.Length; i++)
            {
                if (ordernumber == validValues[i]) 
                {
                    itemInStock = true;
                    break;
                }

            }
            if (itemInStock == true)
            {
                Console.WriteLine("The item is in stock");
            }
            else 
            {
                Console.WriteLine("Sorry the item is not in stock!");
            }

        }
    }
}
