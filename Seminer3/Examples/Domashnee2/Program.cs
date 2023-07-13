// Расстояние между двумя точками в координате в 3D
double Primer(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2,2));
}

Console.WriteLine("Введите координаты первой точки");
int x1 = int.Parse(Console.ReadLine()!);
int y1 = int.Parse(Console.ReadLine()!);
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты второй точки");
int x2 = int.Parse(Console.ReadLine()!);
int y2 = int.Parse(Console.ReadLine()!);
int z2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Расстояние между точками:");
double result = Primer(x1, x2, y1, y2, z1, z2);
Console.WriteLine(result);