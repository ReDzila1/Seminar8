//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Mass(int M, int N)
{
    if (M != N)
    {
        if (M % 2 == 0) 
        {
            Console.WriteLine(M);
            Console.WriteLine("-");
            Mass(M + 1, N);
        }
        else Mass(M + 1, N);
    }
}
Console.WriteLine("Введите число M");
int r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int c = int.Parse(Console.ReadLine()!);
Console.WriteLine();
if(r < c)
{
    Console.WriteLine($"Четные числа в диапозоне от {r} до {c}:");
    Mass(r, c);
}
else Console.WriteLine("Первое число должно быть меньше второго");