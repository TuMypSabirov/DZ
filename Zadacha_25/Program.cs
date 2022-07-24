// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.WriteLine("Введите число A");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = int.Parse(Console.ReadLine());

int getMethod(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}
int res = getMethod(numA, numB);
Console.WriteLine(res);