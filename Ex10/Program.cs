using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number : ");
            int number = int.Parse(Console.ReadLine());
            int result = Function(number);
            Console.WriteLine("result is: " + result);
            Console.ReadLine();
        }
        static int Function(int number)
        {
            int res = 0;
            while (number > 0)
            {
                res = res * 10 + (number % 10);
                number = number / 10;
            }
            return res;
        }
    }
}
