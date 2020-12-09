using System;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Double hour1, hour2;
            Double hoursWorked, hoursWorked2;
            Double anualSal, anualSal2; 
            
                   

            // Welcome screen!
            Console.WriteLine("Anonymous Income Comparison Program.");
            // ask the hourly rate of the first user. 
            Console.WriteLine("What is your hourly rate person 1 ?");
            hour1 = Convert.ToDouble((Console.ReadLine()));
            // ask the hours worked a per week 
            Console.WriteLine("What is your hours worked rate person 1 ?");
            hoursWorked = Convert.ToDouble((Console.ReadLine()));
            anualSal = hour1 * hoursWorked * 52 ;// gets hours times hours worked times 52week in the year 
            Console.WriteLine("Annual salary of Person 1: " + anualSal);// gives you the annual salary


            // get input from the second person 
            Console.WriteLine("What is your hourly rate person 2 ?");
            hour2 = Convert.ToDouble((Console.ReadLine()));
            // ask the hours worked a per week 
            Console.WriteLine("What is your hours worked rate person 2 ?");
            hoursWorked2 = Convert.ToDouble((Console.ReadLine()));
            anualSal2 = hour2 * hoursWorked2 * 52;// gets hours times hours worked times 52week in the year 
            Console.WriteLine("Annual salary of Person 2: " + anualSal2);// gives you the annual salary



            // prints out true or false if Does Person 1 make more money than Person 2? 
            Console.WriteLine("“Does Person 1 make more money than Person 2? ");
            if ((anualSal > anualSal2))
            {
                Console.WriteLine("Ture");
            }
            else
            {
                Console.WriteLine("False");
            }





        }
    }
}
