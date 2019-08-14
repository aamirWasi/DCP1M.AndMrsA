using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP1M.AndMrsA
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                string line = Console.ReadLine();
                var space = line.Split(' ');
                int num1 = int.Parse(space[0]);
                int num2 = int.Parse(space[1]);
                Console.WriteLine($"Case {t}: {CountSquares(num1,num2)}");
            }
        }
        static int CountSquares(int a,int b)
        {
            int count = 0;
            for (int i = a; i <=b; i++)
            {
                for (int j = 0; j*j <=i; j++)
                {
                    if (j * j == i)
                        count++;
                }
            }
            return count;
        }
    }
}
