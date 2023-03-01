using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21
{
    class Program
    {
		public static void Main(String[] args)
		{

			Console.WriteLine("enter USN code :");
			String usn_no = Console.ReadLine();
			if (validation(usn_no))
			{
				Console.WriteLine("valid usn code");
			}
			else
			{
				Console.WriteLine("invalid usn code");
			}
			Console.ReadLine();
		}

		static bool validation(String code)
		{
			if (code.Length == 10)
			{
				int c1 = code[0];
				if (c1 >= 48 && c1 < 60)
				{
					char c2 = code[1];
					char c3 = code[2];
					if ((c2 >= 'A' && c2 <= 'Z') && (c3 >= 'A' && c3 <= 'Z'))
					{ //
						char c4 = code[3];
						char c5 = code[4];
						if ((c4 >= '0' && c4 <= '9') && (c5 >= '0' && c5 <= '9'))
						{
							char c6 = code[5];
							char c7 = code[6];
							String c6_7 = "";
							c6_7 += c6;
							c6_7 += c7;
							if (c6_7.Equals("CS") || c6_7.Equals("IT") || c6_7.Equals("ME") || c6_7.Equals("EC"))
							{
								char c8 = code[3];
								char c9 = code[4];
								char c10 = code[9];
								if ((c8 >= '0' && c8 <= '9') && (c9 >= '0' && c9 <= '9') && (c10 >= '0' && c10 <= '9'))
								{
									return true;
								}
							}
						}
					}
				}
			}
			return false;
		}
	}
}
