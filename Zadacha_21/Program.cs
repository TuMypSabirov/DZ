// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("введите xa");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("введите ya");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("введите za");
int za = int.Parse(Console.ReadLine());

Console.WriteLine("введите xb");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("введите yb");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("введите zb");
int zb = int.Parse(Console.ReadLine());

double Distance(int xaLocal, int yaLocal, int zaLocal, int xbLocal, int ybLocal, int zbLocal)
{
    double Dis = Math.Sqrt(Math.Pow((xbLocal - xaLocal), 2) + Math.Pow((ybLocal - yaLocal), 2) + Math.Pow((zbLocal - zaLocal), 2));
    return Dis;
}

Console.WriteLine("{0:f2}", Distance(xa, ya, za, xb, yb, zb));
