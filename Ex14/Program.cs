using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("enter your option 1.binary surching integers 2.binary surching string  ");
			int choice = Convert.ToInt32(Console.ReadLine());
			switch (choice)
			{
				case 1:
					BinarySurchIntegers();
					break;
				case 2:
					BinarySurchStrings();
					break;
				default:
					Console.WriteLine("wrong inpt :");
					break;

			}

		}
		static void BinarySurchStrings()
		{
			Console.WriteLine("enter how many strings you entering: ");
			int size = int.Parse(Console.ReadLine());
			String[] inputstring = new String[size];
			for (int i = 0; i < size; i++)
			{
				inputstring[i] = Console.ReadLine();
			}
			Console.WriteLine("enter key string: ");
			String key = Console.ReadLine();
			if (Binary_surch(key, inputstring))
			{
				Console.WriteLine("String founded");
			}
			else
			{
				Console.WriteLine("String not founded");
			}


		}
		static bool Binary_surch(String key, String[] inputstring)
		{
			int l = 0, r = inputstring.Length;
			while (l <= r)
			{
				int mid = (l + r) / 2;

				int res = key.CompareTo(inputstring[mid]);

				if (res == 0)
				{
					return true;
				}
				else if (res > 0)
				{
					l = mid + 1;
				}
				else if (res < 0)
				{
					r = mid - 1;
				}
			}
			return false;
		}
		static void BinarySurchIntegers()
		{
			Console.WriteLine("enter a no of elements you enter");
			int n = int.Parse(Console.ReadLine());
			int[] inputarray = new int[n];
			Console.WriteLine("enter array elements ");
			for (int i = 0; i < n; i++)
			{
				inputarray[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("enter key: ");
			int key = int.Parse(Console.ReadLine());

			if (Binary_surch_integer(inputarray, key))
			{
				Console.WriteLine("element found");
			}
			else
			{
				Console.WriteLine("element not found");
			}
		}

		static bool Binary_surch_integer(int[] inputarray, int key)
		{
			int l = 0, r = inputarray.Length;
			while (l <= r)
			{
				int mid = (l + r) / 2;
				if (inputarray[mid] == key)
				{
					return true;
				}
				else if (inputarray[mid] > key)
				{
					r = mid - 1;

				}
				else if (inputarray[mid] < key)
				{
					l = mid + 1;
				}
			}
			return false;
		}
	}
}
