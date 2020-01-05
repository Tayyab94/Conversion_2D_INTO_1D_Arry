using System;

namespace Convert2D_Arry_int_1D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int n1, n2, i, j, k = 0;

            int[] str1 = new int[12];
            int[,] str2 = new int[12, 12];

            Console.WriteLine("Enter the rows and Columns :");
            n1 = int.Parse(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Element in 2-D Array ");

            for (i = 0; i < n1; i++)
            {
                for ( j = 0; j < n2; j++)
                {
                    str2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("IN 2-D Array");

            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.WriteLine($"{i} {j} = {str2[i, j]}");
                }
            }


            Console.WriteLine("convert In 1-D Arry");

            for ( i = 0; i < n1; i++)
            {
                for ( j = 0; j < n2; j++)
                {
                    str1[k++] = str2[i, j];
                }
            }


            for (i = 0; i < n1*n2; i++)
            {
                Console.WriteLine("str [{0}] = {1} \t", i, str1[i]);
            }

            Console.ReadKey();
        }
    }
}
