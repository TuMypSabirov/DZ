// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
if (a > 99)
{
    string b = a.ToString();
    Console.WriteLine(b[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}