using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a no of elements you enter");
            int n = int.Parse(Console.ReadLine());
            int[] inputarray = new int[n];
            Console.WriteLine("enter array elements ");
            for (int i = 0; i < n; i++)
            {
                inputarray[i] =int.Parse(Console.ReadLine());
            }
            Sort(n, inputarray);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(inputarray[i] + " ");
            }
            Console.ReadLine();
        }
        static void Sort(int n, int[] arr)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
