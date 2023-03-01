using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23
{
    class Program
    {
		public static void Main(String[] args)
		{
			
			Console.WriteLine("enter sentance");
			String sentance = Console.ReadLine();
			int len = sentance.Length;
			String[] array = new String[len - 1];
			int[] count = new int[len - 1];
			sentance = convert(sentance);
			seqvence(array, sentance);
			int[] arr = Count(array, count);

			for (int i = 0; array[i] != null; i++)
			{
				if (array[i] != "")
				{
					Console.WriteLine(array[i] + " - " + count[i]);
				}
			}
			Console.ReadLine();
		}

		static String convert(String sentance)
		{
			String res = "";
			for (int i = 0; i < sentance.Length; i++)
			{
				int current = sentance[i];
				if ((current > 64 && current < 91) || (current > 97 && current < 123))
				{
					char temp = sentance[i];
					res += temp;
				}
			}
			return res;
		}

		static int[] Count(String[] array, int[] count)
		{

			for (int i = 0; array[i] != null; i++)
			{
				for (int j = 0; array[j] != null; j++)
				{
					if (array[i].Equals(array[j]))
					{
						count[i]++;
						if (count[i] > 1)
						{
							array[j] = "";
						}
						//array[j]=" ";
					}
				}
			}
			return count;
		}

		static void seqvence(String[] array, String sentance)
		{
			int len = sentance.Length;
			int index = 0;
			for (int i = 0; i < len - 1; i++)
			{
				char current = sentance[i];
				if (current <= 90 && current >= 65)
				{
					int tep = current;
					current = (char)(tep + 32);
				}
				else if (current >= 90 && current >= 122)
				{
					int tep = current;
					current = (char)(tep);
				}

				char next = sentance[i + 1];
				if (next <= 90)
				{
					int tep = next;
					next = (char)(tep + 32);
				}
				if ((current + 1) == next)
				{
					String temp = "";
					temp += current;
					temp += next;
					array[index] = temp;
					index++;

				}

			}
		}
	}
}
