using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assinment
{
    class UC8
    {
        public static void find_even_odd()
        {
            
            Console.WriteLine("Enter a Number:- ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("This is Even Number.");
                Console.Read();
            }


            else
            {
                Console.WriteLine("This is Odd Number.");
                Console.Read();
            }
        }
    }
}
