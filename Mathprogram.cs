using System;

namespace console_application
{
    class Program
    {
       

        static void Main(string[] args)
        { 
            Console.WriteLine("Enter your number to multiply by 50");
            string num = Console.ReadLine();
            int num2 = Int32.Parse(num);
            int total = num2 * 50;

            Console.WriteLine("The total is: " + total);



            // Takes input and adds 25 to it  
            Console.WriteLine("Enter your number to add by 25");
            string num1 = Console.ReadLine();
            int num3 = Int32.Parse(num1);
            int total2 = num3 + 25;

            Console.WriteLine("The total is: " + total2);

            // Takes the number and divides it by 12.5. 
            Console.WriteLine("Enter your number and it divides it by 12.5. ");
            string num5 = Console.ReadLine();
            int num4 = Int32.Parse(num5);
            int total3 = (int)(num4 / 12.5);

            Console.WriteLine("The total is: " + total3);



            //Takes the input and checks if it is greater than 50 and prints true or false. 
            Console.WriteLine("Enter your number and  checks if it is greater than 50 and prints true or false. ");
            int n = int.Parse(Console.ReadLine());
            if ((n > 50))
            {
                Console.WriteLine("Ture");
            }
            else
            {
                Console.WriteLine("False");
            }



            // Takes an input and divides it by 7 and prints out the remainder 
            Console.WriteLine("Enter your number and it divides it by 7 and prints the remainder");
            string number1 = Console.ReadLine();
            int number2 = Int32.Parse(number1);
            int total7 = (number2 % 7);

            Console.WriteLine("The total is: " + total7);







        }
    }
}
