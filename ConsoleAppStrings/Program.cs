using System;

namespace ConsoleAppStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Suresh");

            sb.Append(", Rohini");

            sb.Append(", Trishika");

            Console.WriteLine(sb);
        }
    }
}
