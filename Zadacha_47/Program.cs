// Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

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

Console.WriteLine("Введите число строк(m): ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число столбцов(n): ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m, n];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);