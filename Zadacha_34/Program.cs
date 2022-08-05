// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(99, 1000);
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

int ColChCh(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int quantity = 0;

    while (index < count)
    {
        if (collection[index] % 2 == 0)
        {
            quantity++;
        }
        index++;
    }
    return quantity;
}

int[] array = new int[4];

FillArray(array);

PrintArray(array);
Console.WriteLine();

int quan = ColChCh(array);
Console.WriteLine("Количество чётных чисел: " + quan);