// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

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

void Element(int[,] matr)
{
    Console.WriteLine("Введите положение строки(y): ");
    int y = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите положение столбца(x): ");
    int x = int.Parse(Console.ReadLine());

    if (y < matr.GetLength(0) || x < matr.GetLength(1))
    {
        Console.WriteLine($"Элемент[{y}, {x}] => " + matr[y, x]);
    }
    else
    {
        Console.WriteLine($"Элемент[{y}, {x}] => ERROR. Нет такой позиции в массиве");
    }
}

int[,] matrix = new int[5, 5];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Element(matrix);










