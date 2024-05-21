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
            // 1차원 배열
            int[] a = { 1, 2, 3, 4 };
            string[] vars = { "파인애플", "사과", "바나나" };

            Console.WriteLine(vars[vars.Length-1]); // 위치-1
            
            // 2차원 배열 - 1차원 배열을 여러개 가질 수 있다.
            int[,] abc = { { 1, 2, 3, 5 }, { 4, 5, 6, 7 }, { 4, 5, 6, 7 } }; // 1차원 배열의 열 크기는 같아야됨 ex) 3 3 4 4 이런식으로
            Console.WriteLine(abc[1, 1]);
            Console.WriteLine(abc[1/* 2차원 배열의 자리 */, 0 /* 1차원 배열의 자리 */]);
            
            // 가변배열
            int[][] ab = new int[3][];
            ab[0] = new int[4];
            ab[1] = new int[4];
            ab[2] = new int[3];
            // int[,] abc = { { 1, 2, 3, 5 }, { 4, 5, 6, 7 }, { 4, 5, 4 } };
            ab[2][2] = 4;
            ab[0][0] = 4;
            Console.WriteLine(ab[2][2]);
            Console.WriteLine("길이는? "+ab.Length);

        }
    }
}