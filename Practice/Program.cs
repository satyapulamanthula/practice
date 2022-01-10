using System;

namespace Practice
{
    class Program
    { 
        public static void MethodName(ref int val)
        {
            val++;
        }
        static void Main(string[] args)
        {
            int value = 20;
            MethodName(ref value);
            Console.WriteLine(value);
            Console.ReadLine();
           // Console.WriteLine("Hello World!");
        }
    }
}
