using System;

namespace OutKeyword
{
    class Program
    {
        public static void MethodValue(out int val)
        {
            val=20;
        }
        static void Main(string[] args)
        {
            int value;
            //Console.WriteLine("old value: " + value);
            MethodValue(out value);
            Console.WriteLine("New value: "+value);
            Console.ReadLine();
            //Console.WriteLine("Hello World!");
        }
    }
}
