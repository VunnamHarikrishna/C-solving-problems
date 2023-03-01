using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22
{
    class Program
    {
		public static void Main(String[] args)
		{
			
			Console.WriteLine("enter sentance");
			String sentance = Console.ReadLine();
			sentance += ' ';
			String result = Convertstring(sentance);
			Console.WriteLine(result);
			Console.ReadLine();
		}

		static String Convertstring(String str)
		{
			int len = str.Length;
			String result = "";
			for (int i = 0; i < len; i++)
			{
				String word = "";
				for (; i < len; i++)
				{
					if (str[i] == ' ' || str[i] == '.')
					{

						result += validate(word);

						if (str[i] == ' ')
						{
							result += ' ';
						}
						else if (str[i] == '.')
						{
							result += '.';
						}
						break;
					}
					else
					{
						char temp = str[i];
						word += temp;
					}
				}
				//result+=' ';
			}
			return result;
		}

		static String validate(String word)
		{
			int len = word.Length;
			String res = word;
			bool ver = true;
			for (int i = 0; i < len; i++)
			{
				int temp = word[i];
				if (temp <= 60 && temp > 47)
				{
					ver = false;
				}
			}
			if (ver)
			{
				res = reverse(word);
			}
			else
			{
				res = numcheck(word);
			}
			return res;
		}

		static String numcheck(String word)
		{
			int len = word.Length;
			String res = "";
			bool check = false;
			for (int i = 0; i < len; i++)
			{
				int temp = word[i];
				if (temp > 60)
				{
					check = true;
				}
			}
			if (check)
			{
				String word1 = "";
				for (int i = 0; i < len; i++)
				{
					int temp = word[i];
					if (temp < 61)
					{
						word1 += word[i];
					}
					else
					{
						res += word1;
						String tem = "";
						for (; i < len; i++)
						{
							temp = word[i];
							if (temp > 60)
							{
								tem += word[i];
							}
							else if (temp <= 60)
							{
								break;
							}
						}
						String remining_char = reverse(tem);
						res += remining_char;
					}
				}
			}
			else
			{
				res = word;
			}
			return res;
		}

		static String reverse(String word)
		{
			int len = word.Length;
			String res = "";
			for (int i = len - 1; i >= 0; i--)
			{
				char temp = word[i];
				res += temp;
			}
			return res;
		}
	}
}
