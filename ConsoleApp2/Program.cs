using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine(a);
            void A()
            {
                int a = 7;
                Console.WriteLine(a);
            }

            void B()
            {
                int b = 9;
                Console.WriteLine(b);
            }
            A();
            B();
        }
    }
}