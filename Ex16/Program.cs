using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayData();
			Console.ReadLine();
        }
		static void ArrayData()
		{
			Console.WriteLine("enter a no of elements you enter");
			int n = int.Parse(Console.ReadLine());
			int[] inputarray = new int[n];
			Console.WriteLine("enter array elements ");
			for (int i = 0; i < n; i++)
			{
				inputarray[i] =int.Parse( Console.ReadLine());
			}
			Console.WriteLine("enter your choice: 1.buble sort 2.insertion sort");
			int choice = int.Parse(Console.ReadLine());
			switch (choice)
			{
				case 1:
					buble_sort(inputarray);
					break;
				case 2:
					Insertion_sort(inputarray);
					break;
				default:
					Console.WriteLine("invalid option");
					break;
			}
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(inputarray[i] + "  ");
			}
		}
		static void buble_sort(int[] inputarray)
		{
			int n = inputarray.Length;
			for (int i = 1; i < n; i++)
			{
				for (int j = 0; j < n - 1; j++)
				{
					if (inputarray[j] > inputarray[i])
					{
						int temp = inputarray[j];
						inputarray[j] = inputarray[i];
						inputarray[i] = temp;
					}
				}
			}

		}
		static void Insertion_sort(int[] inputarray)
		{
			int n = inputarray.Length;
			for (int i = 1; i < n; i++)
			{
				int curent = inputarray[i];
				int j = i;
				while (j > 0 && inputarray[j - 1] > curent)
				{
					inputarray[j] = inputarray[j - 1];
					j--;
				}
				inputarray[j] = curent;
			}
		}
	}
}
