// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();

static int FunAckermann(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if (b == 0)
    {
        return FunAckermann(a - 1, 1);
    }
    else
    {
        return FunAckermann(a - 1, FunAckermann(a, b - 1));
    }
}

Console.WriteLine("A(m,n)=" + FunAckermann(m, n));
