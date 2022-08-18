// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write($"{i + 1}{") "}");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
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

void GetSum(int[,] matr)
{
    int[] arr = new int[2];
    arr[0] = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }

        if (sum < arr[0] || arr[0] == 0)
        {
            arr[0] = sum;
            arr[1] = i + 1;
        }
    }
    Console.WriteLine
    ($"Строка с наименьшей суммой элементов: {arr[1]}");
}
int[,] matrix = new int[4, 4];

FillArray(matrix);
Console.WriteLine();

PrintArray(matrix);
Console.WriteLine();

GetSum(matrix);
