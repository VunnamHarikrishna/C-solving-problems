using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name: ");
            string inputstring = Console.ReadLine();
            HelloFun(inputstring);
            Console.ReadLine();
        }

        private static void HelloFun(string inputstring)
        {
            Console.WriteLine("Hello " + inputstring + " !");
        }
    }
}
