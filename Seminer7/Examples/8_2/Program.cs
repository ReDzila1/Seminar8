//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Mass(int r, int c)
{
    int[,] arr = new int[r,c];
    Random random = new Random();
    
    int s = 0; int s2 = 0;int k = 0;

    for (int i = 0; i < r; i++)
    {
        s = 0;
        for (int j = 0; j < c; j++)
        {
            arr[i, j] = new Random().Next(1,10);
            Console.Write("{0,6} ", arr[i, j]);
            s += arr[i,j];
        }
        if (i == 0)
        {
            s2 = s;
            k = i + 1;
        }
        else {if(s > s2) {s2 = s; k = i + 1;}}

        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine($"Строка №{k} имеет наибольшую сумму из элементов равная {s2}");
}



Console.WriteLine("Введите количество строк");
int r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбоц");
int c = int.Parse(Console.ReadLine()!);

if (r == c)
{
    Mass(r, c );
}
else Console.WriteLine("Массив должен быть квадратным");