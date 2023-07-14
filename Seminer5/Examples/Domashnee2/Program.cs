// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[5];
int K = 0;
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(100, 999);
   Console.Write(array[i] + " ");
   if (i % 2 == 1) K += array[i];
}
Console.WriteLine();
Console.Write("Сумма чисел, стоящих на нечетных позициях = ");
Console.WriteLine(K);