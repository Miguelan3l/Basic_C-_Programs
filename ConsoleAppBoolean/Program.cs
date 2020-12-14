using System;

namespace ConsoleAppBoolean
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Do a boolean comparison using a while statement.
            Console.WriteLine("Hello World!, This programs helps you count to TEN ");
            int i = 0; // initialization

            while (i < 11) 
            {
                Console.WriteLine("Number: = {0}", i);
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                
                i++;
            }

            //Do a boolean comparison using a do while statement.

            Console.WriteLine("Hello World! , This program helps you with your multiplication by 10!  ");
            int table = 10;
            int s = 1;
            int result;

            do
            {
                result = table * s;
                Console.WriteLine("{0}*{1}={2}", table, s, result);
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                s++;
            }
            while (s <= 10);
            Console.ReadLine(); 


        }
    }
}
