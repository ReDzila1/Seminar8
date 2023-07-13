// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Напишите число, кубы до которого (включительно) нужны");

int N = int.Parse(Console.ReadLine());
int c = 1;
if (N > 1)
{
    Console.WriteLine("Кубы до числа " + N);
    while (c <= N)
    {
        Console.WriteLine(Math.Pow(c,3));
        c++;
    }
}
else if ( N == 0 || N == 1)
{
    Console.WriteLine(N);
}
else {
    Console.WriteLine("Число должно быть положительным");
}