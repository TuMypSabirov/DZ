// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void GetSequence(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int x = 0; x < matr.GetLength(1) - 1; x++)
            {
                if (matr[i, x] < matr[i, x + 1])
                {
                    int num = matr[i, x + 1];
                    matr[i, x + 1] = matr[i, x];
                    matr[i, x] = num;
                }
            }
        }
    }
}

int[,] matrix = new int[4, 4];

FillArray(matrix);
Console.WriteLine();

PrintArray(matrix);
Console.WriteLine("    >>>>");

GetSequence(matrix);

PrintArray(matrix);
