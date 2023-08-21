﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end.");
            }
            else
            {

                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                if ((width * length * height) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. At this point the program would end.");
                }
                else
                {

                    int shippingCharge = ((height * width * length) * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is:"+shippingCharge);
                    Console.WriteLine("Thank you!");
                }

            }

        }
    }
}
