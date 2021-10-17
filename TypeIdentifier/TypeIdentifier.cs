using System;

namespace TypeIdentifier
{
    class TypeIdentifier
    {
        static void Main(string[] args)
        {
            while (true)
            {
                VerifyType();
            }            
        }

        static void VerifyType()
        {
            Console.WriteLine("enter something");
            string input = Console.ReadLine();

            if (Byte.TryParse(input, out _))
            {
                Console.WriteLine($"{input} is Unsigned 8-bit integer (byte)");
            }
            else if (SByte.TryParse(input, out _))
            {
                Console.WriteLine($"{input} is Signed 8-bit integer (sbyte");
            }
            else if (Int16.TryParse(input, out _))
            {
                Console.WriteLine($"{input} is Signed 16-bit integer (short)");
            }
            else if (UInt16.TryParse(input, out _))
            {
                Console.WriteLine($"{input} is Unsigned 16-bit integer (ushort)");
            }
            else if (Int32.TryParse(input, out _))
            {
                Console.WriteLine($"{input} is Signed 32-bit integer (int)");
            }
            else if (UInt32.TryParse(input, out _))
            {
                Console.WriteLine($"{input} is Unsigned 32-bit integer (uint)");
            }
            else if (Int64.TryParse(input, out _))
            {
                Console.WriteLine($"{input} is Signed 64-bit integer (long)");
            }
            else if (UInt64.TryParse(input, out _))
            {
                Console.WriteLine($"{input} is Unsigned 64-bit integer (ulong)");
            }
            else if (Single.TryParse(input, out _))
            {
                Console.WriteLine($"{input} is Float");
            }
            else if (Double.TryParse(input, out _))
            {
                Console.WriteLine($"{input} is Double");
            }
            else if (Decimal.TryParse(input, out _))
            {
                Console.WriteLine($"{input} is Decimal");
            }
            else if (Boolean.TryParse(input, out _))
            {
                Console.WriteLine($"{input} is boolean");
            }
            else if (Char.TryParse(input, out _))
            {
                Console.WriteLine($"{input} is char");
            }
            else
            {
                Console.WriteLine($"{input} is string");
            }
        }
    }
}
