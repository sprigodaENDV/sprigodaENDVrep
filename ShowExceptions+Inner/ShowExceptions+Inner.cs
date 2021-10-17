using System;
using System.Text.RegularExpressions;

namespace ShowExceptions_Inner
{
    class ShowExceptions_Inner
    {

        static void Main(string[] args)
        {
            Console.WriteLine(@"Please enter your adress for validation. 
                              In case you don't use conventional formatting, the program will be persistent in its enquiry");
            AcceptEmail();
            AcceptPhoneNumber();
            AcceptDateOfBirth();
            AcceptZipCode();
            AcceptURL();
        }


        static void AcceptEmail()
        {
            bool tryBool = true;
            while (tryBool)
            {
                try
                {                    
                    string mask = @"^\w+[a-zA-Z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+)\.\w{2,4}";
                    Console.WriteLine("Enter your e-mail  :");
                    string read = Console.ReadLine();
                    bool ifMatches = Regex.IsMatch(read, mask);
                    if (ifMatches) 
                    { 
                        Console.WriteLine("Wow, you suceeded entering email");
                        tryBool = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                    Console.WriteLine(ex.InnerException.StackTrace);
                }
                finally 
                {
                    Console.WriteLine("Want to try to enter email again? Press Y then.");
                    ConsoleKeyInfo k = Console.ReadKey();                   
                    if (k.Key == ConsoleKey.Y) { tryBool = true; }
                }
            }
        }


        static void AcceptPhoneNumber()
        {
            bool tryBool = true;
            while (tryBool)
            {
                try
                {
                    string mask = @"\+373\d{3}\d{2}\d{3}";
                    Console.WriteLine("Enter your Moldovian phone number  :");
                    string read = Console.ReadLine();
                    bool ifMatches = Regex.IsMatch(read, mask);
                    if (ifMatches) 
                    { 
                        Console.WriteLine("Wow, you suceeded entering phone number");
                        tryBool = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                    Console.WriteLine(ex.InnerException.StackTrace);
                }
                finally
                {
                    Console.WriteLine("Want to try to enter phone number again? Press Y then.");
                    ConsoleKeyInfo k = Console.ReadKey();
                    if (k.Key == ConsoleKey.Y) { tryBool = true; }
                }
            }
        }


        static void AcceptDateOfBirth()
        {
            bool tryBool = true;
            while (tryBool)
            {
                try
                {
                    string mask = @"\d{2}\.\d{2}.\d{4}";
                    Console.WriteLine("Enter your date of birth in DD.MM.YYYY format :");
                    string read = Console.ReadLine();
                    bool ifMatches = Regex.IsMatch(read, mask);
                    if (ifMatches) 
                    { 
                        Console.WriteLine("Wow, you suceeded entering date of birth");
                        tryBool = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                    Console.WriteLine(ex.InnerException.StackTrace);
                }
                finally
                {
                    Console.WriteLine("Want to try to enter date of birth again? Press Y then.");
                    ConsoleKeyInfo k = Console.ReadKey();
                    if (k.Key == ConsoleKey.Y) { tryBool = true; }
                }
            }
        }


        static void AcceptZipCode()
        {
            bool tryBool = true;
            while (tryBool)
            {
                try
                {
                    string mask = @"MD\d{4}";
                    Console.WriteLine("Enter your zip code in MD-xxxx format :");
                    string read = Console.ReadLine();
                    bool ifMatches = Regex.IsMatch(read, mask);
                    if (ifMatches)
                    { 
                        Console.WriteLine("Wow, you suceeded entering your zip code");
                        tryBool = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                    Console.WriteLine(ex.InnerException.StackTrace);
                }
                finally
                {
                    Console.WriteLine("Want to try to enter zip code again? Press Y then.");
                    ConsoleKeyInfo k = Console.ReadKey();
                    if (k.Key == ConsoleKey.Y) { tryBool = true; }
                }
            }
        }


        static void AcceptURL()
        {
            bool tryBool = true;
            while (tryBool)
            {
                try
                {
                    string mask = @"^http(s) ?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$";
                    Console.WriteLine("Enter your web adress :");
                    string read = Console.ReadLine();
                    bool ifMatches = Regex.IsMatch(read, mask);
                    if (ifMatches) 
                    { 
                        Console.WriteLine("Wow, you suceeded entering web adress");
                        tryBool = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                    Console.WriteLine(ex.InnerException.StackTrace);
                }
                finally
                {
                    Console.WriteLine("Want to try to enter your web adress again? Press Y then.");
                    ConsoleKeyInfo k = Console.ReadKey();
                    if (k.Key == ConsoleKey.Y) { tryBool = true; }
                }
            }
        }

    }
}
