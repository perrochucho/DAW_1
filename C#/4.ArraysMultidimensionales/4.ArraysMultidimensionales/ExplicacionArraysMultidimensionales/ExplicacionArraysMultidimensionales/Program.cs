using System;

namespace ExplicacionArraysMultidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Explicaciones

            int[,] array = new int[3, 4]; //Asi se hace un array de 3 x 4 (3 filas 4 columnas)

            int[,] array2 = { { 1, 0, 12, -1 } ,  // 00, 01, 02, 03
                              { 7, -3, 2, 5} ,    // 10, 11, 12, 13
                              { 5, -2, 2, -9} }; //  20, 21, 22, 23

            array[0, 0] = 10;

            Console.WriteLine(array2[2,3]);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(array2[i, j]);
                }
            }

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.WriteLine(array2[i,j]);
                }
            }
            Console.WriteLine();
            EscribeArray3x4(array2);

            #endregion
        }
        static void EscribeArray3x4( int[,] a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(a[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
