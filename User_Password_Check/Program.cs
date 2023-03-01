using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter username:");
        string userName = Console.ReadLine();
        string password;
        string passwordconform;
        bool passwordValid;

        do
        {
            Console.WriteLine("Enter password:");
            password = Console.ReadLine();
            Console.WriteLine("Enter password for conform:");
            passwordconform = Console.ReadLine();
            passwordValid = passwordValidation(password);
            Console.WriteLine(passwordValid);
            if (passwordValid)
            {
                Console.WriteLine("you Enterinvalid password Enter agin: ");
            }
            else
            {
                if (password == passwordconform)
                {

                    Console.WriteLine("passwordAcepted");
                    Console.WriteLine(" \n\ncheck your deatails \nuserName " + userName + " password " + password);
                }
                else
                {
                    Console.WriteLine("you Enterinvalid password Enter agin: ");
                    passwordValid = true;
                }
            }
        } while (passwordValid);

        Console.ReadLine();
    }
    static bool passwordValidation(string password)
    {
        if (password.Length >= 8)
        {
            if (Upperlettervalid(password))
            {
                if (Spciallettervalid(password))
                {
                    if (Numbervalid(password))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return true;
            }
        }
        else
        {
            return true;
        }
    }
    static bool Upperlettervalid(string str)
    {
        bool check = false;
        for (int i = 0; i < str.Length; i++)
        {
            int temp = str[i];
            if (temp <= 90 && temp > 64)
            {
                return true;
            }
        }
        return check;
    }
    static bool Numbervalid(string str)
    {
        bool check = false;
        for (int i = 0; i < str.Length; i++)
        {
            int temp = str[i];
            if (temp <= 57 && temp > 47)
            {
                return true;
            }
        }
        return check;
    }
    static bool Spciallettervalid(string str)
    {
        bool check = false;
        for (int i = 0; i < str.Length; i++)
        {
            int temp = str[i];
            if ((temp > 32 && temp < 48) || (temp > 57 && temp < 65) || (temp > 90 && temp < 97) || (temp > 122 && temp < 127))
            {
                return true;
            }
        }
        return check;
    }
}
