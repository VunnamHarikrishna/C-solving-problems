using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
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
				inputarray[i] = int.Parse(Console.ReadLine());
			}
			Insertion_sort(inputarray);
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(inputarray[i] + " ");
			}
		}
		static void Insertion_sort(int[] inputarray)
		{
			int len = inputarray.Length;
			for (int k = 1; k < len; k++)
			{
				int curent = inputarray[k];
				int j = k;
				while (j > 0 && inputarray[j - 1] > curent)
				{
					inputarray[j] = inputarray[j - 1];
					j--;
				}
				inputarray[j] = curent;
				Display(inputarray);
			}
		}

        private static void Display(int[] inputarray)
        {
            for (int i=0;i< inputarray.Length;i++)
            {
                Console.WriteLine(inputarray[i]);
            }
        }
    }
}
