using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24
{
    class Program
    {
		public static void Main(String[] args)
		{

			String input = Console.ReadLine();
			input = Convert(input);
			String result = countstring(input);
			Console.WriteLine(result);
			Console.ReadLine();
		}

		static String countstring(String str)
		{
			String res = "";
			int len = str.Length;
			char[] chr = new char[len];
			int[] count = new int[len];
			int index = 0;

			for (int i = 0; i < len; i++)
			{
				char temp = str[i];
				if (i == 0)
				{
					chr[0] = str[0];
					index++;
				}
				else
				{
					if (temp != chr[index - 1])
					{
						chr[index] = str[i];
						index++;
					}
				}
			}
			index = 0;
			for (int i = 0; i < len; i++)
			{
				int cout = 0;
				for (; i < len && chr[index] == str[i]; i++)
				{
					cout++;
				}
				count[index] = cout;
				index++;
				i--;
			}
			for (int i = 0; i < len && count[i] != 0; i++)
			{
				//System.out.print(chr[i]+" "+count[i]);
				char te = (char)(count[i] + 48);
				res += chr[i];
				res += te;
			}
			return res;
		}

		static String Convert(String str)
		{
			int len = str.Length;
			String res = "";
			for (int i = 0; i < len; i++)
			{
				char temp = str[i];
				//char t=str.charAt(i);
				if (temp >= 'A' && temp <= 'Z')
				{
					temp = (char)(temp + 32);
					res += temp;
				}
				else
				{
					res += temp;
				}
			}
			return res;
		}
	}
}
