// Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void Mass(int r, int c, int r_n, int c_n)
{
    int[,] arr = new int[r,c];

    Random random = new Random();

    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            arr[i, j] = new Random().Next(1,20);
            Console.Write("{0,6} ", arr[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    if ( (r_n < r) && (c_n < c))
    {
        Console.WriteLine($"На позиции [{r_n},{c_n}] находится число " + arr[r_n, c_n]);
    }
    else Console.WriteLine("Данная позиция отсутствует в массиве");
}




Console.WriteLine("Введите количество строк");
int r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбоц");
int c = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите позиции интересующего элемента");

int r_n = int.Parse(Console.ReadLine()!);

int c_n = int.Parse(Console.ReadLine()!);

Mass(r, c ,r_n ,c_n);
