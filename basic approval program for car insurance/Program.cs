using System;

namespace basic_approval_program_for_car_insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            bool DUI;
            int Tick;
            bool qual;

            Console.WriteLine("What is your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            Tick = Convert.ToInt32(Console.ReadLine());

             qual = ( age >= 15 && ( DUI = false ) || Tick <= 3 );
            Console.WriteLine("Qualified? " + qual);

        }
    }
}
