using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomDetailGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            //input is here so I can use it in all my code.
            string input;
            do
            {
                //Parse the string to double so the user can input a decimal.
                Console.WriteLine("Please enter the length");
                string length = Console.ReadLine();
                double l = double.Parse(length);

                Console.WriteLine("Please enter the width");
                string width = Console.ReadLine();
                double w = double.Parse(width);

                Console.WriteLine("Please enter the height");
                string height = Console.ReadLine();
                double h = double.Parse(height);

                //declaring my variables.
                double p;
                double a;
                double v;

                p = 2 * l + 2 * w;
                Console.WriteLine("Perimeter: " + p);

                a = l * w;
                Console.WriteLine("Area: " + a);

                v = l * w * h;
                Console.WriteLine("Volume: " + v);

                Console.WriteLine("Do you want to continue measuring rooms?? y/n");
                input = Console.ReadLine();
            }
            //this loop ends if n is the input and loops if y is the input.
            while (input == "y");
        }
  
    }
}
