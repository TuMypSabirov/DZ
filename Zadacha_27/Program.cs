// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int Method(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
int sum = Method(num);
Console.WriteLine(sum);