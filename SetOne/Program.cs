using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number for genarate table for it :");
            int number = int.Parse(Console.ReadLine());
            GenarateTable(number);
            Console.ReadLine();
        }

        private static void GenarateTable(int number)
        {
            for(int i = 0; i < 13; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + (i * number));
            }
        }
    }
}
