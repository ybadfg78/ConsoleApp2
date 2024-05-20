using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float floatValue = 5.5f;
            int int1;
            
            void Toint(float _parameter1)
            {
                int1 = (int)_parameter1;
            }

            Toint(floatValue);
            Console.WriteLine(int1);
        }
    }
}