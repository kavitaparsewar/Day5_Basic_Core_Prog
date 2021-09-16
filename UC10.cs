using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assinment
{
    class UC10
    {
        public static void Find_Large ()
            {
            Console.WriteLine("Enter three numbers : ");
            Console.WriteLine("--------------------");

            Console.WriteLine("Enter First number : ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number : ");
            int third = int.Parse(Console.ReadLine());

            if (first > second)
            {
                
                if (first > third)
                {
                    Console.WriteLine("largest number : " + first);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("largest number : " + second);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }


        }
    }
}
