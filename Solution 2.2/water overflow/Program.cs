﻿using System;

namespace water_overflow
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (sum + liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                sum += liters;
            }
            Console.WriteLine(sum);
        }
    }
}
