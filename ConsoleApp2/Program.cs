using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            
            //if(true)
            if(b>a)
            {
                a++;
                Console.WriteLine("a의 값은?" + a);
            }

            //if(false)
            if (b < a)
            {
                a--;
                Console.WriteLine("a의 값은?" + a);
            }

            if (b < a)
            {
                b--;
                Console.WriteLine("b의 값은?" + b);
            }
            else
            {
                b = b - 2;
                Console.WriteLine("b의 값은?" + b);
            }

            Console.WriteLine("=====================");
            int money = 8000;
            if(money < 5000)
            {
                Console.WriteLine("money가 5000미만일 때 동작");
            }
            else if(money <7000)
            {
                Console.WriteLine("money가 5000이상 7000미만일 때 동작");
            }
            else if (money < 9000)
            {
                Console.WriteLine("money가 7000이상 9000미만일 때 동작");
            }
            else
            {
                Console.WriteLine("money가 9000이상일 때 동작.");
            }

        }
    }
}