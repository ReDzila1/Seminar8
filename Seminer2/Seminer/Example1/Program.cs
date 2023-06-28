
int number = Convert.ToInt32(Console.ReadLine());
if (number >=100 && number <1000)
{
    int mid = number % 100;
    int mid2 = number % 10;
    int count = mid - mid2;
    count = count / 10;
    System.Console.WriteLine($"Вторая цифра числа " + number + " является " + count);
}
else
{
    System.Console.WriteLine("Это число не трехзначное"); 
}  