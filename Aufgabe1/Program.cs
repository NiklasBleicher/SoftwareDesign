using System;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            uint x; //32-bit -> 4 Byte
            ushort y; //16bit -> 2 Byte
            long z; //64bit -> 8 Byte

            string test = "Hello, World"; //12 Characters * 16-Bit = 192 byte = 24 Byte 
            
            Console.WriteLine(test.Length);
            Console.Read();
        }
    }
}