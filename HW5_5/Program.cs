using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленое значение строк и столбцов массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[N, N];
            //int p = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                   if (((i + j) % 2)==0)
                    {
                        t[i, j] = 1;
                    }
                    else
                    {
                        t[i, j] = 0;
                    }
                    Console.Write("{0,2}", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
