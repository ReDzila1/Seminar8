// Создать двумерный массив вещественных чисел

void Mass(int r, int c)
{
    double[,] arr = new double[r,c];

    Random random = new Random();

    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            arr[i, j] = random.NextDouble() * 1000;
            Console.Write("{0,8:F2}", arr[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбоц");
int c = int.Parse(Console.ReadLine()!);
Mass(r,c);