using System;

namespace Ref_Keyword
{
    class Program
    {
        public static void MethodValue(ref int val)
        {
            val = 10;
        }
        static void Main(string[] args)
        {
            int value = 20;
            Console.WriteLine("oldvalue: " + value);
            MethodValue(ref value);
            Console.WriteLine("New value: " + value);
            Console.ReadLine();
            //Console.WriteLine("Hello World!");
        }
    }
}
