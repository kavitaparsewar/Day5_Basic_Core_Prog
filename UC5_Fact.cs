﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assinment
{
    class UC5_Fact
    {
        public static void find_factor()
        {

           
            Console.WriteLine("Enter the Number:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                  
                    Console.WriteLine(+i);
                }
            }
           

        }

    }
}
