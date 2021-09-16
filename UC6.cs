using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assinment
{
    class UC6
    {
        public static void findQR()
        {
         	Console.Write("Enter first number:");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number:");
			int num2 = Convert.ToInt32(Console.ReadLine());

			int que = num1 / num2;
			int remain = num1 % num2;

			Console.WriteLine("Quotient is:" + que);
			Console.WriteLine("Remainder is:" + remain);
		}
    }
}
