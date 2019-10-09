using System;
using System.Linq;

namespace ConsoleApplication
{
    
    internal static class Program
    {
        public static void Main(string[] args)
        {
            uint x; //32-bit -> 4 Byte
            ushort y; //16bit -> 2 Byte
            long z; //64bit -> 8 Byte

            string test = "Hello, World"; //12 Characters * 16-Bit = 192 bit = 24 Byte;
            
            //Write every char from test String 
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            //Print every int in list and search for 5, return index
            int[] list = {2, 3, 4, 5, 6, 7, 8};
            foreach (var entry in list)
            {
                if (entry == 5)
                {
                    var index = Array.IndexOf(list, 5);
                    Console.Write("Found 5: "  + index + "\n");
                }
                else
                {
                    Console.Write(entry + "\n");
                }
            }
            //Declare Object from Test Class
            Test test1 = new Test();
            test1.Alter = 13;
            Console.WriteLine("The Test is " + test1.Alter + " old!");
            
            //Call Function Add
            Add(4,5);
            //Keep Console Open
            Console.Read();
            
        }
        //Simple Math Addition 
        private static void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }

    public class Test
    {
        public int Alter;
    } 
}