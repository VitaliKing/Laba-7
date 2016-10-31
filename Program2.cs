using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            if (n == 0 || m ==0)
            {
                Console.WriteLine("Задан пустой массив");
                Console.ReadKey();
                return;
            }
            int[,] A = new int[n,m];
            Random R = new Random();
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = R.Next(0, 21);
                    Console.Write("{0}\t", A[i, j]);
                }
                Console.WriteLine();
            }
            for (int j = 0; j<m; j++)
            {
                int[] p = new int[n];
                for (int i= 0; i<n; i++)
                {
                    p[i] = A[i, j];
                }
                Array.Sort(p);
                Console.WriteLine();
                for (int i= 0; i< n; i++)
                {
                    Console.Write("{0}\t",p[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
