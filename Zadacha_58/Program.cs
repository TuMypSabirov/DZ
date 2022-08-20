// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    PrintArray(arr);
}

void ProductArray(int[,] arr1, int[,] arr2)
{
    int[,] NewArray = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            NewArray[i, j] = arr1[i, j] * arr2[i, j];
        }
    }
    PrintArray(NewArray);
}

int[,] arrayA = new int[4, 4];
int[,] arrayB = new int[4, 4];

Console.WriteLine("  Массив A");
FillArray(arrayA);
Console.WriteLine();

Console.WriteLine("  Массив B");
FillArray(arrayB);
Console.WriteLine();

Console.WriteLine("Произведение элементов массивов:");
ProductArray(arrayA, arrayB);
