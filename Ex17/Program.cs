using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name: ");
            String input = Console.ReadLine();
            Display(input);
            Console.ReadLine();
        }
        static void Display(String input)
        {
            int len = input.Length;
            for (int i = 0; i < len; i++)
            {
                int temp = input[i];
                if (temp >= 65 && temp <= 90)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }

    }
}
