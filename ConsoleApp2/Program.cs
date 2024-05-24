
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
            Class1 class1 = new Class1();
            int c = class1.addNumber(a, b);
            class1.soundFunction();
            
            Console.WriteLine(c);
        }
    }
}