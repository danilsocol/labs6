using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mainMas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } }; // первый массив
            int[,] noMainMas = { { 1, 2, 3 }, { 4, 5, 6 } };                            // второй массив

            int rowsMainMas = mainMas.GetUpperBound(0) + 1;
            int rowsNoMainMas = noMainMas.GetUpperBound(0) + 1;

            int rightNum = Check(rowsMainMas, rowsNoMainMas, mainMas, noMainMas);
            Console.WriteLine(Resulation(rightNum, noMainMas));

        }
        static bool Resulation(int rightNum, int[,] noMainMas)
        {
            return rightNum == noMainMas.Length;
        }

        static int Check(int rowsMainMas, int rowsNoMainMas, int[,] mainMas, int[,] noMainMas)
        {
            int rightNum = 0;

            for (int i = 0; i < rowsMainMas; i++)
            {
                for (int a = 0; a < rowsNoMainMas; a++)
                {
                    for (int j = 0; j < noMainMas.Length / rowsNoMainMas; j++)
                    {
                        if (mainMas[i, j] == noMainMas[a, j])
                        {
                            rightNum++;
                        }
                    }
                }
            }
            return rightNum;
        }

    }
}
