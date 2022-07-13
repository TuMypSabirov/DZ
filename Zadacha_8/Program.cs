// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine());
for (int a = 1; a <= N; a++)
{
    if (a % 2 == 0) Console.WriteLine(a);
}