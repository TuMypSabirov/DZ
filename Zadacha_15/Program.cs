// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Введите порядковый номер дня недели ");
int d = int.Parse(Console.ReadLine());
if (d < 8)
{
    if (d < 6)
    {
        Console.WriteLine("рабочий день");
    }
    else
    {
        Console.WriteLine("выходной");
    }
}
else
{
    Console.WriteLine("нет такого дня недели");
}