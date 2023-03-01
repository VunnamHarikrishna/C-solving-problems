using System;


namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your string: ");
            String input = Console.ReadLine();
            Console.WriteLine("enter your num: ");
            int num =int.Parse(Console.ReadLine());
            Display(input,num);
            Console.ReadLine();
        }
        static void Display(String input,int num)
        {
            int len = input.Length;
            int []arr=new int[26];
            string inputmodify = "";
            for (int i = 0; i < len; i++)
            {
                int temp = input[i]+num;
                char a = (char)temp;
                inputmodify += a;
                arr[temp-64]++;
            }
            for (int i = 0; i < 26; i++)
            {
                if (arr[i] > 0)
                {
                    if (arr[i] == 1)
                    {
                        char a = (char)(i + 64);
                        Console.Write(a);
                    }
                    else{
                        char a = (char)(i + 64);
                        Console.Write(a + "" + arr[i]);
                    }
                    
                    
                }
                
            }
            


        }

    }
}
