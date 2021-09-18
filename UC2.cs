using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assinment
{
    class UC2
    {
        public static void Leap()
        {
            
            Console.WriteLine("Enter year : ");

            int year = Convert.ToInt32(Console.ReadLine());
            
            if (year % 4 == 0)
                Console.WriteLine( year + " is leap year");
            else
                Console.WriteLine( year + " is not leap year");

        }
        
    }

 }

