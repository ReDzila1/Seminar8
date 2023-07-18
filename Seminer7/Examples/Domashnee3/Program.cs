// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Mass(int r, int c)
{
    int[,] arr = new int[r,c];

    Random random = new Random();

    int s = 0;
    int k = 0;
    int st = 1;


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
    for (int i = 0; i < c; i++)
    {
        for (int j = 0; j < r; j++)
        {
            s += arr[j,i];
            k += 1;
        }

        var av = Math.Round((double) s / k, 2);

        Console.WriteLine($"Среднее арифметическое {st} столбца  = {av}");

        st++;
        k = 0; s = 0;

    }

}




Console.WriteLine("Введите количество строк");
int r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбоц");
int c = int.Parse(Console.ReadLine()!);


Mass(r, c);
