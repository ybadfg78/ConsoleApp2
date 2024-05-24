
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
            int b = 6;
            Prog2 prog2 = new Prog2();
            Console.WriteLine(prog2.a);
            Console.WriteLine(prog2.b);
        }
    }

    class Prog2
    {
        public string a = "a";
        public int b = 2;

        private static void newFunction()
        {
            Console.WriteLine("NEW");
        }

        static void prog3(string[] args)
        {
            newFunction();
        }
    }
}