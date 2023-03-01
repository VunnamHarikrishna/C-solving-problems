using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number for array size1 : ");
            int size1 = int.Parse(Console.ReadLine());
            int[] inputarr1 = new int[size1];
            for (int i = 0; i < size1; i++)
            {
                Console.WriteLine("enter array element " + (i + 1) + " : ");
                inputarr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter a number for array size2 : ");
            int size2 = int.Parse(Console.ReadLine());
            int[] inputarr2 = new int[size2];
            for (int i = 0; i < size2; i++)
            {
                Console.WriteLine("enter array element " + (i + 1) + " : ");
                inputarr2[i] = int.Parse(Console.ReadLine());
            }
            int[] result = new int[size1>size2?size1:size2];
            if (size1 > size2)
            {
                int i=0;
                for (i = 0; i < size2; i++)
                {
                    result[i] = inputarr1[i] + inputarr2[i];
                }
                for (; i < size1; i++)
                {
                    result[i] = inputarr1[i];
                }
            }
            else
            {
                int i=0;
                for (i = 0; i < size1; i++)
                {
                    result[i] = inputarr1[i] + inputarr2[i];
                }
                for (; i < size2; i++)
                {
                    result[i] = inputarr2[i];
                }
            }
            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
