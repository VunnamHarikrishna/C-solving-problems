using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number : ");
            int size = int.Parse(Console.ReadLine());
            int[] inputarr = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("enter array element " + (i+1) + " : ");
                inputarr[i] = int.Parse(Console.ReadLine());
            }
           int sum= Function(inputarr);
            Console.WriteLine("sum of this array is :" + sum);
            Console.ReadLine();
        }

        private static int Function(int[] inputarr)
        {
            int sum = 0;
            for(int i = 0; i < inputarr.Length; i++)
            {
                sum = sum + inputarr[i];
            }    

            return sum;
        }
    }
}
