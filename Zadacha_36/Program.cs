// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int GetSum(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int summa = 0;

    while (index < count)
    {
        if (index % 2 == 1)
        {
            summa = summa + collection[index];
            index++;
        }
        index++;
    }
    return summa;
}

int[] array = new int[4];

FillArray(array);

PrintArray(array);
Console.WriteLine();

int sum = GetSum(array);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);