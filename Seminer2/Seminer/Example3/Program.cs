int a = Convert.ToInt32(Console.ReadLine());
if (a > 7 || a < 1) Console.WriteLine("Число должно быть в диапазоне от 1 до 7");

switch (a)
{
    case 1:
        Console.WriteLine("Понедельник");
        Console.WriteLine("Не выходной");
        break;
    case 2:
        Console.WriteLine("Вторник");
        Console.WriteLine("Не выходной");
        break;
    case 3:
        Console.WriteLine("Среда");
        Console.WriteLine("Не выходной");
        break;
    case 4:
        Console.WriteLine("Четверг");
        Console.WriteLine("Не выходной");
        break;
    case 5:
        Console.WriteLine("Пятница");
        Console.WriteLine("Не выходной");
        break;
    case 6:
        Console.WriteLine("Суббота");
        Console.WriteLine("Выходной!");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        Console.WriteLine("Выходной!");
        break;
}