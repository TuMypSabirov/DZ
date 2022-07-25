// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] myArr = new int[8];

Console.WriteLine("Введите первое число ");
myArr[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
myArr[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число ");
myArr[2] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите четвертое число ");
myArr[3] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите пятое число ");
myArr[4] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите шестое число ");
myArr[5] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите седьмое число ");
myArr[6] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите восьмое число ");
myArr[7] = int.Parse(Console.ReadLine());

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(myArr);