using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringhandling5
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountl = 0;
            // char counter from user input
            Console.WriteLine("Input some text for calculationg letters 'L': ");
            string stringtocalc = Console.ReadLine().ToUpper();
            for (int i = 0; i < stringtocalc.Length; i++)
            {
                if (stringtocalc[i] == ('A' | 'E' | 'I' | 'O' | 'U' | 'Y' | 'Ä' | 'Ö'))
                {
                    amountl++;
                }
            }

            Console.WriteLine("Amount of 'L' is: '{0}'", amountl);
            Console.ReadKey();
        }
    }
}
