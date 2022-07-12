// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numB = int.Parse(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine("Число "+numA+" больше чем "+numB);
}
else
{
    Console.WriteLine("Число "+numB+" больше чем "+numA);
}