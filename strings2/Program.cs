using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings2
{
    class Program
    {
        static void Main(string[] args)
        {
            // char counter from user input
            Console.WriteLine("Input some text for changing letters 'e' to '@': ");
            string stringtochange = Console.ReadLine();
            Console.WriteLine("Modification is: '{0}'", stringtochange.Replace("e", "@"));
            Console.ReadKey();
        }
    }
}
