using System;

namespace S4L1_2C
{
    class Program
    {
        static void Main(string[] args)
        {

            void sum_byte(char c1, char c2)
            {
                byte bit_selector = 1;
                for (int i = 0; i < 7; i++)
                {
                    c1 = (char)(c1 | (c2 & bit_selector));
                    bit_selector <<= 1;
                }
                Console.Write(c1);
            }

            string s1 = "Anton", s2 = "Ivanov";
            Console.Write($"{s1} + {s2} = ");

            for (int i = 0; i < s2.Length; i++)
            {
                if (i < s1.Length)
                {
                    sum_byte(s1[i], s2[i]);
                }
                else
                    Console.Write(s2[i]);
            }

        }
    }
}
