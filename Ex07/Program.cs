using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number to find prime or not :");
            int number = int.Parse( Console.ReadLine());
            if (Function(number))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }

        private static bool Function(int number)
        {
            int count = 0;
            for(int i = 2; i <= (number / 2); i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
