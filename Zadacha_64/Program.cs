// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

string Numbers(int m, int n)
{
    if (m == n) return n.ToString();
    else return m.ToString() + ", " + Numbers(m += 1, n);
}

Console.WriteLine(Numbers(numM, numN));