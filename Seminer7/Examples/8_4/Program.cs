//  Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
void Mass(int[,] Array, int r, int c)
{
    Random random = new Random();
    int m = Array[0,0];
    int k = 0;
    int l = 0;
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            Array[i, j] = new Random().Next(0,50);
            if (m < (Array[i, j]))
            {
                m = Array[i, j];
                k = i;
                l = j;
            }
            Console.Write("{0,6} ", Array[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine("-------------------------------------");
    Console.WriteLine($"{m} {k} {l}");
    Console.WriteLine();
    int[,] Arr = new int[r, c];
        for (int i = 0; i < r; i++)
        {
            if (i != k)
            {
                for (int j = 0; j < c; j++)
                {
                    if (j != l)
                    {
                        Arr[i, j] = Array[i, j];
                        Console.Write("{0,6} ", Arr[i, j]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
}



Console.WriteLine("Введите количество строк для первого массива");
int r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов для первого массива");
int c = int.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine("-------------------------------------");
Console.WriteLine();

int[,] A = new int[r,c];



Mass(A, r, c);