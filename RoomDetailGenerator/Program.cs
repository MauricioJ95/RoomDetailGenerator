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
            string input;
            do
            {
                Console.WriteLine("Please enter the length");
                string length = Console.ReadLine();
                double l = double.Parse(length);

                Console.WriteLine("Please enter the width");
                string width = Console.ReadLine();
                double w = double.Parse(width);

                Console.WriteLine("Please enter the height");
                string height = Console.ReadLine();
                double h = double.Parse(height);

                double p;
                double a;
                double v;

                p = 2 * l + 2 * w;
                Console.WriteLine("Perimeter: " + p);

                a = l * w;
                Console.WriteLine("Area: " + a);

                v = l * w * h;
                Console.WriteLine("Volume: " + v);

                Console.WriteLine("Do you want to continue measuring rooms? y/n");
                input = Console.ReadLine();
            }
            while (input == "y");
        }
  
    }
}
