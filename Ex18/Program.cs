using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            String password = genaratepassword();
            Console.WriteLine(password);
			Console.ReadLine();
        }
		private static String genaratepassword()
		{
			Console.WriteLine("enter our first name: ");
			String firstname = Console.ReadLine();
			Console.WriteLine("enter middle name: ");
			String middlename = Console.ReadLine();
			Console.WriteLine("enter last name: ");
			String lastname = Console.ReadLine();
			Console.WriteLine("enter age name: ");
			String age = Console.ReadLine();
			String password = "";
			char fis = firstname[0];
			char mid = middlename[0];
			char las = lastname[0];
			password += fis;
			password += mid;
			password += las;
			password += age;
			return password;
		}
	}
}
