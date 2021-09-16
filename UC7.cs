using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assinment
{
    class UC7
    {
        public static void swap_num()
            {
            Console.WriteLine("Enter the two numbers for swapping: ");
            Console.WriteLine("Enter First Number : ");

            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter Second Number :");

            int num2 = int.Parse(Console.ReadLine());
            int temp = num1;

            num1 = num2;
            num2 = temp;

            Console.WriteLine("\nAfter Swapping numbers are : ");
            Console.WriteLine("\nFirst Number : " + num1);
            Console.WriteLine("\nSecond Number : " + num2);
            Console.Read();
        }

    }
}
