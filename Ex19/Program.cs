using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter student 1 name :");
            String student1name = Console.ReadLine();
            Console.WriteLine("enter student 2 name :");
            String student2name = Console.ReadLine();
            String student1result = Exchange(student1name, student2name);
            String student2result = Exchange(student2name, student1name);
            Console.WriteLine("stdent1result: " + student1result + "\nstdent2result : " + student2result);
			Console.ReadLine();
        }
		static String Exchange(String student1name, String student2name)
		{
			String result = "";
			for (int i = 0; i < student1name.Length; i++)
			{
				char temp = student1name[i];
				if (temp == ' ')
				{
					break;
				}
				else
				{
					result += temp;
				}
			}
			result += ' ';
			for (int i = 0; i < student2name.Length; i++)
			{
				char temp = student2name[i];
				if (temp == ' ')
				{
					for (int j = i + 1; j < student2name.Length; j++)

					{
						temp = student2name[j];
						result += temp;
					}
				}
			}
			return result;
		}
	}
}
