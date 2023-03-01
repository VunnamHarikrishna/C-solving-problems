using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25
{
    class Program
    {
		public static void Main(String[] args)
		{

			Console.WriteLine("enter a no of elements you enter");
			int n = int.Parse(Console.ReadLine());
			int[] inputarray = new int[n];
			Console.WriteLine("enter array elements ");
			for (int i = 0; i < n; i++)
			{
				inputarray[i] = int.Parse(Console.ReadLine());
			}
			Checmethod(inputarray);
			Console.ReadLine();

		}

		static void Checmethod(int[] inputarray)
		{
			int len = inputarray.Length;
			for (int i = 0; i < len; i++)
			{
				for (int j = i + 1; j < len; j++)
				{
					int temp = inputarray[i] + inputarray[j];
					if (check(temp, inputarray))
					{
						Console.WriteLine("<" + inputarray[i] + "," + inputarray[j] + "," + temp + ">");
					}
				}
			}
		}

		static bool check(int temp, int[] inputarray)
		{
			for (int i = 0; i < inputarray.Length; i++)
			{
				if (inputarray[i] == temp)
				{
					return true;
				}
			}
			return false;
		}
	}
}
