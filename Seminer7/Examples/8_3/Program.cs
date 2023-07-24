//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Mass(int[,] Array, int r, int c)
{
    Random random = new Random();

    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            Array[i, j] = new Random().Next(0,20);
            Console.Write("{0,6} ", Array[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine("-------------------------------------");
    Console.WriteLine();
}
static void Um(int[,] a, int[,] b)
    {
        int[,] r = new int[a.GetLength(0), b.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    r[i,j] += a[i,k] * b[k,j];
                }
                Console.Write("{0,6} ", r[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

Console.WriteLine("Введите количество строк для первого массива");
int r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов для первого массива");
int c = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество строк для второго массива");
int r2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов для второго массива");
int c2 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("-------------------------------------");
Console.WriteLine();

int[,] A = new int[r,c];
int[,] B = new int[r2,c2];


if (c == r2)
{
    Mass(A, r, c);
    Mass(B, r2, c2);
    Um(A,B);
}
else Console.WriteLine("Количество столбцов первого массива должно быть равно количеству строк второго");