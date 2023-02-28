using System;

namespace S4L1_2C
{
    class Program
    {
        static void Main()
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

            Console.WriteLine("Input your first name");
            string? s1 = Console.ReadLine();
            Console.WriteLine("Input your first name");
            string? s2 = Console.ReadLine();

            if (s1 != null && s2 != null && s1 != "" && s2 != "") {
                Console.Write($"{s1} + {s2} = ");

                if (s1.Length > s2.Length) {
                    string buf = s2;
                    s2 = s1;
                    s1 = buf;
                } // итого, s2 длиннее (или равно по длине) s1

                for (int i = 0; i < s2.Length; i++) { 
                        sum_byte(s1[i % s1.Length], s2[i]);
                }
            } else {
                Console.WriteLine("Incorrect input!!!");
            }
        }
    }
}
