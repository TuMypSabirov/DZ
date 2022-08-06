// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
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

int GetMax(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int maximum = collection[index];

    while (index < count)
    {
        if (collection[index] > maximum)
        {
            maximum = collection[index];

        }
        index++;
    }
    return maximum;
}

int GetMin(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int minimum = collection[index];

    while (index < count)
    {
        if (collection[index] < minimum)
        {
            minimum = collection[index];
        }
        index++;
    }
    return minimum;
}



int[] array = new int[5];

FillArray(array);

PrintArray(array);
Console.WriteLine();

int difference = GetMax(array) - GetMin(array);

Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + difference);