using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("enter a no of elements you enter");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] inputarray = new int[n];
			Console.WriteLine("enter array elements ");
			for (int i = 0; i < n; i++)
			{
				inputarray[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("enter key element: ");
			int key = Convert.ToInt32(Console.ReadLine());
			if (Surch(n, inputarray, key))
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine("false");
			}
			Console.ReadLine();
		}
		static bool Surch(int n, int[] arr, int key)
		{
			for (int i = 0; i < n; i++)
			{
				if (arr[i] == key)
				{
					return true;
				}
			}
			return false;
		}

	}
}
