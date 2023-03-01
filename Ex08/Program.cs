using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter input1: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter input2: ");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter input3: ");
            int input3 = int.Parse(Console.ReadLine());
            if ((input1>input2)&&(input1 > input3))
            {
                Console.WriteLine(input1+" is big");
            }else if ((input2 > input1) && (input2 > input3))
            {
                Console.WriteLine(input2 + " is big");
            }
            else
            {

                Console.WriteLine(input3 + " is big");
            }
            Console.ReadLine();
        }
    }
}
