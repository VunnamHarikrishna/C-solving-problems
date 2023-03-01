using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number for factorial :");
            int number = int.Parse(Console.ReadLine());
            int result = Factorial(number);
            Console.WriteLine("factorial of given number is :" +result);
            Console.ReadLine();
        }

        private static int Factorial(int number)
        {
            int res = 1;
            while (number > 1)
            {
                res = res * number;
                number--;
            }
            return res;
        }
    }
}
