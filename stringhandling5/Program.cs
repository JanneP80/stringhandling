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
            // char counter from user input for vowels
            Console.WriteLine("Input some text for calculationg vowels: ");
            string stringtocalc = Console.ReadLine().ToUpper();
            for (int i = 0; i < stringtocalc.Length; i++)
            {
                if (stringtocalc[i] == 'A' | stringtocalc[i] == 'E' | stringtocalc[i] == 'I' | stringtocalc[i] == 'O' | stringtocalc[i] == 'U' | stringtocalc[i] == 'Y' | stringtocalc[i] == 'Ä' | stringtocalc[i] == 'Ö')
                {
                    amountl++;
                }
            }

            Console.WriteLine("Amount of vowels is: '{0}'", amountl);
            Console.ReadKey();
        }
    }
}
