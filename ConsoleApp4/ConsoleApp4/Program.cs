using System;
using System.ComponentModel.Design;

namespace ConsoleApp4
{
    class Program 
    {
        static void Main(string[] args)
        {
            // // Слабонервным не смотреть!!!!

            Console.WriteLine("Выберите пример от 1 до 7");
            int Example = Convert.ToInt32(Console.ReadLine());
            Selection(Example);
        }

        static void Selection(int Example)
        {
            switch (Example)
            {
                case 1:
                    {
                        
                        int[] mainMas = { 1, 2, 3, 4, 5 };
                        int[] noMainMas = { 2, 3 };
                        Outout(mainMas, noMainMas);
                    }
                    break;

                case 2:
                    {
                        int[] mainMas = { 1, 2, 3, 4, 5 };
                        int[] noMainMas = { 1, 2, 4 };
                        Outout(mainMas, noMainMas);
                    }
                    break;

                case 3:
                    {
                        int[] mainMas = { 1, 2, 3, 4, 5 };
                        int[] noMainMas = { 2, 6 };
                        Outout(mainMas, noMainMas);
                    }
                    break;

                case 4:
                    {
                        int[,] mainMas = { { 1, 2, 3 }, { 3, 4, 5 }, { 7, 8, 9 } };
                        int[,] noMainMas = { { 3, 4, 5 }, { 7, 8, 9 } };
                        Output(mainMas, noMainMas);
                    }
                    break;

                case 5:
                    {
                        int[,] mainMas = { { 1, 2, 3 }, { 3, 4, 5 }, { 7, 8, 9 } };
                        int[,] noMainMas = { { 3, 4, 5 }};
                        Output(mainMas, noMainMas);
                    }
                    break;

                case 6:
                    {
                        int[,] mainMas = { { 1, 2, 3 }, { 3, 4, 5 }, { 7, 8, 9 } };
                        int[] noMainMas = {  3, 4, 5  };
                        Outout(mainMas, noMainMas);
                    }
                    break;

                case 7:
                    {
                        int[,] mainMas = { { 1, 2, 3 }, { 3, 4, 5 }, { 7, 8, 9 } };
                        int[,] noMainMas = { { 3, 4, 5 }, { 6, 7, 8 } };
                        Output(mainMas, noMainMas);
                    }
                    break;
            }
        }
        static bool Resulation(int Matching, int leghtNoMainMas)
        {
            return Matching == leghtNoMainMas;
        }

        static void Outout(int[] mainMas,int[] noMainMas)
        {
            int rowsMainMas = mainMas.GetUpperBound(0) + 1;
            int rowsNoMainMas = noMainMas.GetUpperBound(0) + 1;

            int beforeNoMainMas = Check(rowsMainMas, rowsNoMainMas, mainMas, noMainMas);
            int Matching = NeedNumTogether(beforeNoMainMas, rowsNoMainMas, mainMas, noMainMas);

            int leghtNoMainMas = noMainMas.Length;
            Console.WriteLine(Resulation(Matching, leghtNoMainMas));
        }

        static void Output(int[,] mainMas, int[,] noMainMas)
        {
            int rowsMainMas = mainMas.GetUpperBound(0) + 1;
            int rowsNoMainMas = noMainMas.GetUpperBound(0) + 1;

            int beforeNoMainMas = Check(rowsMainMas, rowsNoMainMas, mainMas, noMainMas);
            int Matching = NeedNumTogether(beforeNoMainMas, rowsNoMainMas, mainMas, noMainMas);

            int leghtNoMainMas = noMainMas.Length;
            Console.WriteLine(Resulation(Matching, leghtNoMainMas));
        }

        static void Outout(int[,] mainMas, int[] noMainMas)
        {
            int rowsMainMas = mainMas.GetUpperBound(0) + 1;
            int rowsNoMainMas = noMainMas.GetUpperBound(0) + 1;

            int beforeNoMainMas = Check(rowsMainMas, rowsNoMainMas, mainMas, noMainMas);
            int Matching = NeedNumTogether(beforeNoMainMas, rowsNoMainMas, mainMas, noMainMas);

            int leghtNoMainMas = noMainMas.Length;
            Console.WriteLine(Resulation(Matching, leghtNoMainMas));
        }

        static int Check(int rowsMainMas, int rowsNoMainMas, int[] mainMas, int[] noMainMas)
        {
            int beforeNum = 0;

            for (int i = 0; i < rowsMainMas; i++)
            {
                if (mainMas[i] == noMainMas[0])
                {
                    beforeNum = i;
                    break;
                }
            }
            return beforeNum;
        }

        static int NeedNumTogether(int beforeNoMainMas, int rowsNoMainMas, int[] mainMas, int[] noMainMas)
        {
            int Matching = 0;

            for (int i = 0; i < rowsNoMainMas; i++)
            {
                if (mainMas[i + beforeNoMainMas] == noMainMas[i])
                {
                    Matching++;
                }
                else
                {
                    break;
                }
            }
            return Matching;
        }

        static int Check(int rowsMainMas, int rowsNoMainMas, int[,] mainMas, int[,] noMainMas) //561616
        {
            int beforeNum = -1;

            for (int i = 0; i < rowsMainMas; i++)
            {
                if (mainMas[i, 0] == noMainMas[0, 0])
                {
                    beforeNum = i;
                    break;
                }
            }
            return beforeNum;
        }

        static int NeedNumTogether(int beforeNoMainMas, int rowsNoMainMas, int[,] mainMas, int[,] noMainMas)
        {
            int Matching = 0;

            for (int i = 0; i < rowsNoMainMas; i++)
            {
                bool isBreak = false;
                for (int j = 0; j < noMainMas.Length / rowsNoMainMas; j++)
                {
                    if (mainMas[i + beforeNoMainMas, j] == noMainMas[i, j])
                    {
                        Matching++;
                    }
                    else
                    {
                        isBreak = true;
                        break;
                    }
                }
                if (isBreak)
                    break;
            }
            return Matching;
        }

        static int Check(int rowsMainMas, int rowsNoMainMas, int[,] mainMas, int[] noMainMas)
        {
            int beforeNum = -1;

            for (int i = 0; i < rowsMainMas; i++)
            {
                bool isBreak = false;
                for (int j = 0; j < noMainMas.Length / rowsNoMainMas; j++)
                {
                    if (mainMas[i, j] == noMainMas[j])
                    {
                        beforeNum = i;
                        isBreak = true;
                        break;
                    }
                }
                if (isBreak) { break; }

            }
            return beforeNum;
        }

        static int NeedNumTogether(int beforeNoMainMas, int rowsNoMainMas, int[,] mainMas, int[] noMainMas)
        {
            int Matching = 0;

            for (int i = beforeNoMainMas; i < rowsNoMainMas; i++)
            {
                for (int j = 0; j < noMainMas.Length; j++)
                {
                    if (mainMas[i, j] == noMainMas[j])
                    {
                        Matching++;
                    }
                }

            }
            return Matching;
        }
    }
}

