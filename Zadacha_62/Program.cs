// Заполните спирально массив 4 на 4.

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArraySpiral(int[,] fillArray)
{
    int row = fillArray.GetLength(0);
    int col = fillArray.GetLength(1);
    int count = 1, i = 0, j = 0;
    while (count <= row * col)
    {
        fillArray[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < col - 1)
        {
            j++;
        }
        else if (i < j && i + j >= row - 1)
        {
            i++;
        }
        else if (i >= j && i + j > col - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
}

int[,] spiral = new int[4, 4];
ArraySpiral(spiral);
PrintArray(spiral);
