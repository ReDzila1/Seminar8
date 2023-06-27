Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1,
 xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;

int count = 0;

while (count < 10000) 
{
    int what = new Random().Next(0,3);
    if (what == 0)
    {
        x = (xa + x)/2;
        y = (ya + y)/2;
    }
    if (what == 1)
    {
        x = (xb + x)/2;
        y = (yb + y)/2;
    }
    if (what == 2)
    {
        x = (xc + x)/2;
        y = (yc + y)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count += 1;
}