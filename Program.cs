﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N = ");
            long N = long.Parse(Console.ReadLine());
            long s = 0;
            while (N > 0)
            {
                if (N % 2 == 0)
                {
                    s = s + N % 10;
                }
                N = N / 10;
            }
            Console.WriteLine("Сумма четных цифр числа = " + s);
            Console.ReadKey();
        }
    }
}
