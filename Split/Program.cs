using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter sentance");
            string str = Console.ReadLine();
            
            List<string> listofwords = new List<string>();
            listofwords= Split(str);
            Displaywords(listofwords);
            Console.Read();
        }

        private static void Displaywords(List<string> listofwords)
        {
            for(int i=0;i< listofwords.Count;i++)
            Console.WriteLine(listofwords[i]);
        }

        private static List<string> Split(string str)
        {
            List<string> listofwords = new List<string>();

            string tempstr = "";
            for (int i = 0; i <=str.Length; i++)
            {
                if( i == str.Length || str[i] == ' '  )
                {
                   
                    listofwords.Add(tempstr);
                    tempstr = "";
                }
                else
                {
                    tempstr += str[i];
                }
            }
            return listofwords;
        }
    }
}
