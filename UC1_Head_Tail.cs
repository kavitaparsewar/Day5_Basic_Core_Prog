using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assinment
{
    class UC1_Head_Tail
    {
        public static void Head_tail()
        {
            int head = 0;
            int tell = 0;

            
            Console.WriteLine("Enter how many time coin will flip ");

            int count = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i <= count; i++)
            {
               
                int check = random.Next(0, 2);

                if (check <= 0.5)
                {
                    Console.WriteLine("head ");
                    ++tell;
                }


                else
                {
                    Console.WriteLine("tail");
                    ++head;
                }

            }
            Console.WriteLine("count of head and tell is  : " + head + "  " + tell);
            float perhead = (head / count) * 100;
            float pertell = (tell / count) * 100;
            Console.WriteLine("Percentage of head and tell is  : " + perhead + "  " + pertell);
        }

    }
    
}

