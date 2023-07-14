// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
double[] array = new double[5];
double Maximum = 0;
double Minimum = 0;
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(rand.NextDouble() * (50 - (-50)) + (-50),2);

   Console.Write(array[i] + " | ");
   if (array[i] > Maximum) Maximum = array[i];
   else if(array[i] < Minimum) Minimum = array[i];
}
Console.WriteLine();
double K = Maximum - Minimum;
Console.Write("Разность между максимальным и минимальным числом = ");
Console.WriteLine(K);