using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите N - количество строк и столбцов массива:   ");

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(n);

            int[,] array = new int[n, m];
           
            
            
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < n; i++)
            {
                for(int j=0;j<m; j++)

                {

                    array[i, j] = 1 - (i + j) % 2;
                       
                    Console.Write("{0,4}",array[i,j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
