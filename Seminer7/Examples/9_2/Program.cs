//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Mass(int M, int N, int L)
{
    if (M != N)
    {
        Mass(M + 1, N, L + M);
    }
    else Console.WriteLine(L + M);
}
Console.WriteLine("Введите число M");
int r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int c = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int l = 0;
if(r < c)
{
    Console.WriteLine($"Сумма чисел от {r} до {c}");
    Mass(r, c, l);
}
else Console.WriteLine("Первое число должно быть меньше второго");