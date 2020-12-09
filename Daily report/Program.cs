using System;

namespace Daily_report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello " +  Name);
            Console.WriteLine("What course are you on ? ");
            string Course = Console.ReadLine();
            Console.WriteLine(Name +  " is on the " + Course + "Course ");
            Console.WriteLine("What page are you on ? ");
            string Page = Console.ReadLine();
            Console.WriteLine(Name + " is on page " + Page +" of The " + Course + "Course ");
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            string feedback2 = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string exper = Console.ReadLine();
            Console.WriteLine("Thank you for sharing your experience " + Name);
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("Thank you " + Name);
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            Console.WriteLine("Thank you " + Name + " Thank you for your answers. An Instructor will respond to this shortly. Have a great day! ");




        }
    }
}
 