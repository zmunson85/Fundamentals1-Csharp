using System;
using System.Collections.Generic;

namespace Fundamentals

{
    class Program
    {
        // public static void print255()
        // {
        //     for (int i = 1; i < 256; i++)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }
        public static void print3or5()
        {
            for (int i = 1; i < 101; i++)
            {

                if (i % 3 == 0 && !(i % 3 == 0 && i % 5 == 0))
                {
                    Console.WriteLine("Fizz");
                }else if (i % 5 == 0 && !(i % 3 == 0 && i % 5 == 0))
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }


            }
        }
        static void Main(string[] args)
        {
            // print255();
            print3or5();
        }
    }
}