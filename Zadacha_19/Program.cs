// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число: ");

int a = int.Parse(Console.ReadLine());

string b = a.ToString();

if ((b.Length == 5))
{
    if (b[0] == b[4] && b[1] == b[3])
    {
        Console.WriteLine("палиндром");
    }
    else
    {
        Console.WriteLine("не палиндром");
    }
}
else
{
    Console.WriteLine("ERROR. Введите пятизначное число");
}