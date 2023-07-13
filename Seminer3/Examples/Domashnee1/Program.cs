// Палиндром или нет

Console.WriteLine("Введите число: ");
string A = Console.ReadLine();
int len = A.Length;

if (len == 5)
{
    if (A[0] == A[4] && A[1] == A[3])
    {
        Console.WriteLine("Число палиндром");
    }
    else
    {
        Console.WriteLine("Число не палиндром");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}