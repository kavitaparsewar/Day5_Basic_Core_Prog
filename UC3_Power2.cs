using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assinment
{
    class UC3_Power2
    {
        public static void Powerof2()
        {

         
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Calculate power of 2 program");
            if (n < 32)
            {

                Console.WriteLine(n.ToString() + "  to power of 2" + "=" + Math.Pow(2, n));

            }
        }

    }

  }

