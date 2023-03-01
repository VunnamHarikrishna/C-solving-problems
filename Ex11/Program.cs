using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num: ");
            int in1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num: ");
            int in2 = int.Parse(Console.ReadLine());
            double res =(double) in1 / in2;
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
