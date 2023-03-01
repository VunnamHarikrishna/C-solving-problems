using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
			
			Console.WriteLine("enter a startingpoint: ");
			int start_point = int.Parse(Console.ReadLine());
			Console.WriteLine("enter a endingpoint: ");
			int end_point = int.Parse(Console.ReadLine());

			if ((end_point - start_point) > 0)
			{
				int size = end_point - start_point;
				int[] result = new int[size];
				prime(end_point, start_point, result);

				for (int i = 0; i < result.Length; i++)
				{
					if (result[i] == 0)
					{
						break;
					}
					Console.WriteLine(result[i] + "\t");
				}
			}
			else
			{
				Console.WriteLine("(empty list)");
			}
			Console.ReadLine();
		}
		static void prime(int end_point, int start_point, int[] result)
		{
			int index = 0;
			for (int i = start_point; i <= end_point; i++)
			{
				int count = 0;
				if (i == 1 || i == 0)
				{
					count = 1;
				}
				for (int j = 2; j <= (i / 2); j++)
				{
					if (i % j == 0)
					{
						count++;
					}
				}
				if (count == 0)
				{
					result[index] = i;
					index++;
				}
			}
		}
	}
}
