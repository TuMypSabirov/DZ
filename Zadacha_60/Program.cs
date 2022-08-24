// Сформируйте трёхмерный массив из неповторяющихся двузначных 
// чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}[{i},{j},{i}]  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void RandomArray(int[,,] rArray)
{
    int[] oneArray = new int[rArray.GetLength(0) * rArray.GetLength(1) * rArray.GetLength(2)];
    int num;
    for (int i = 0; i < oneArray.GetLength(0); i++)
    {
        oneArray[i] = new Random().Next(10, 100);
        num = oneArray[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (oneArray[i] == oneArray[j])
                {
                    oneArray[i] = new Random().Next(10, 100);
                    j = 0;
                    num = oneArray[i];
                }
                num = oneArray[i];
            }
        }
    }
    int count = 0;
    for (int a = 0; a < rArray.GetLength(0); a++)
    {
        for (int b = 0; b < rArray.GetLength(1); b++)
        {
            for (int c = 0; c < rArray.GetLength(2); c++)
            {
                rArray[a, b, c] = oneArray[count];
                count++;
            }
        }
    }
}

int[,,] arrayA = new int[2, 2, 2];
RandomArray(arrayA);
PrintArray(arrayA);