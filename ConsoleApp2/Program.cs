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
            int[][] numbers = new int[3][];
            numbers[0] = new int[4]{1, 2, 3, 4};
            numbers[1] = new int[3]{5, 6, 7};
            numbers[2] = new int[2]{8, 9};
            
            
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = 0; k < numbers[i].Length; k++)
                {
                    Console.WriteLine(i + ", " + k + "번째 요소:" + numbers[i][k]);
                }
            }

        }
    }
}