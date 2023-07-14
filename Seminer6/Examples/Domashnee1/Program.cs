// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Сколько чисел вы хотите ввести?");
int K = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите числа");
int[] array = new int[K];
int G = 0;
void Vst(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
        if (array[i] > 0) G += 1;
    }
}

Vst(array);
Console.WriteLine("Кол-во положительных чиcел = " + G);