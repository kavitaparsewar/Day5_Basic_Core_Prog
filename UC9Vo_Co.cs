using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assinment
{
    class UC9Vo_Co
    {
        public static void find_vowel_conso()
        {

            Console.WriteLine("Enter Alphabet");

            char choice = Convert.ToChar(Console.ReadLine().ToLower());

            switch (choice)
            {
                case 'a':
                    Console.WriteLine(choice + " is vowel");
                    break;
                case 'i':
                    Console.WriteLine(choice + " is vowel");
                    break;
                case 'o':
                    Console.WriteLine(choice + " is vowel");
                    break;
                case 'u':
                    Console.WriteLine(choice + " is vowel");
                    break;
                case 'e':
                    Console.WriteLine(choice + " is vowel");
                    break;


                default:
                    Console.WriteLine("It is Not a Vowel");
                    break;
            }


            Console.ReadKey();

        }
    }
}
