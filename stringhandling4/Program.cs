using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringhandling4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Palindrom checker from user input
            Console.WriteLine("Input some text for checking if word is a palindrom: ");
            string stringtocheck = Console.ReadLine().ToUpper();
            for (int i = 0; i < stringtocheck.Length; i++)
            {
                if (stringtocheck[i] == (''))
                {
                    Console.WriteLine("Your text is a palindrom.");
                }
                else
                {
                    Console.WriteLine("Your text is NOT a palindrom.");
                }
            }
          
            Console.ReadKey();
        }
    }
}
