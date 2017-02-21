using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // char counter from user input
            Console.WriteLine("Input some text for calculating amount of chars: ");
            string stringforcount = Console.ReadLine();
            Console.WriteLine("Length was: {0}", stringforcount.Length);
            Console.ReadKey();
        }
    }
}
