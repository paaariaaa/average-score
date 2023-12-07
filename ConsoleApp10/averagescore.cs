using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoresAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("please enter first score:");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor= ConsoleColor.Green;
            float a =Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("please enter second score:");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            float b=Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("please enter third score:");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            float c = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            float sum = a + b + c;
            float avg = sum / 3;
            Console.WriteLine("the average is :" + avg);
        }
    }
}
