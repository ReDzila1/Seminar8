//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Mass(int r, int c)
{
    int[,] arr = new int[r,c];

    Random random = new Random();
    
    int z; int v; int l;

    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            arr[i, j] = new Random().Next(1,100);
            v = j;
            while (j > 0)
            {
                z = arr[i, j - 1];
                l = arr[i, j];
                if ((arr[i,j] > arr[i, j - 1]))
                {
                    arr[i, j - 1] = l;
                    arr[i, j] = z;
                }
                j = j - 1;
            }
            j = v;
        }
        for (int j = 0; j < c; j++)
        {
            Console.Write("{0,6} ", arr[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}




Console.WriteLine("Введите количество строк");
int r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбоц");
int c = int.Parse(Console.ReadLine()!);

Mass(r, c );
