// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Задайте сначала k1, а затем b1");
double k1 = double.Parse(Console.ReadLine()!);
double b1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Задайте сначала k2, а затем b2");
double k2 = double.Parse(Console.ReadLine()!);
double b2 = double.Parse(Console.ReadLine()!);

void fun(double k1, double k2, double b1, double b2){
    if (k1 == k2) 
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = (b2 -b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересения двух прямых - [{x};{y}]");
    }
}

fun(k1, k2, b1, b2);
