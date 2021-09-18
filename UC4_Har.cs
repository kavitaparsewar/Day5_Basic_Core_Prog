using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assinment
{
    class UC4_Har
    {
        public static void Main2()
        {

            int i, n;
            double s = 0.0;

            Console.Write("Calculate the harmonic series and their sum:\n");
            

            Console.Write("Input the number of terms : ");

            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", n, s);


        }

    }

        }

