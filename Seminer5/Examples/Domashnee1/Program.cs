// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int[5];
int K = 0;
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(100, 999);
   Console.Write(array[i] + " ");
   if (array[i] % 2 == 0) K += 1;
}
Console.WriteLine();
Console.Write("Количество четных чисел = ");
Console.WriteLine(K);