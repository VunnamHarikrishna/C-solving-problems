using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number : ");
            int number = int.Parse(Console.ReadLine());
            Function(number);
            Console.ReadLine();

        }
        public static void Function(int n)
        {
            int count = 0;
            do
            {
                count++;
                if (n % 2 == 0)
                {
                    Console.WriteLine(n + " is even so i take half: " + n / 2);
                    n = n / 2;
                }
                else
                {
                    Console.WriteLine(n + " is odd so i make 3n+1: " + (3 * n + 1));
                    n = (3 * n + 1);

                }
            } while (n > 1);
            Console.WriteLine("there are total " + count + " steps to reach to 1");
        }
    }
}
