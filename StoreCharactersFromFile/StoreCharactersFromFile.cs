using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;


namespace StoreCharactersFromFile
{
    class StoreCharactersFromFile
    {
        static void Main(string[] args)
        {

            Dictionary<char, int> occurrence = new Dictionary<char, int>();
            Console.WriteLine("enter path to the file");

            while (true)
            {                
                var path = Console.ReadLine();

                if (File.Exists(path))
                {
                    using (FileStream fileStream = File.Open(path, FileMode.Open))
                    {
                        using (StreamReader streamReader = new StreamReader(fileStream, true))
                        {
                            while (streamReader.Peek() >= 0)
                            {
                                char localChar = (char)streamReader.Read();
                                if (!occurrence.TryAdd(localChar, 1))
                                {
                                    int count;
                                    occurrence.TryGetValue(localChar, out count);
                                    occurrence.Remove(localChar);
                                    occurrence.Add(localChar, count + 1);
                                }

                            }
                        }
                    }


                    Console.WriteLine("  Char :  ,  Number of occurrence :  ");
                    foreach (var pair in occurrence)
                    {
                        Console.Write("  " + pair.Key.ToString() + " , " + pair.Value.ToString() + "  ");
                    }
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine(" Can't find your file. Try again");
                }
            }

            Console.WriteLine("The end");
            while (true)
            {
                Console.ReadLine();
            }
        }
    }
}
