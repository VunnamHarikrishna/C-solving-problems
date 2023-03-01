using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first string ");
            String str1 = Console.ReadLine();
            Console.WriteLine("enter second string ");
            String str2 = Console.ReadLine();
            int loc = Comp(str1, str2);
            Console.WriteLine(loc);
        }
		private static int Comp(String anotherstr, String value)
		{
			int len1 = value.Length;
			int len2 = value.Length;
			int lim = Math.Min(len1, len2);
			char[] v1 = value.ToCharArray();
			char[] v2 = anotherstr.ToCharArray();

			int k = 0;
			while (k < lim)
			{
				char c1 = v1[k];
				char c2 = v2[k];
				if (c1 != c2)
				{
					return c1 - c2;
				}
				k++;
			}
			return len1 - len2;
		}
	}
}
