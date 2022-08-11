// Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("введите k1");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine());

double x = 0;
double y = 0;
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

Console.WriteLine();
Console.WriteLine($"Координаты точки пересечения: ({x}, {y})");