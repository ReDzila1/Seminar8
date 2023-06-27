int x = 3, y = 8, z = 5;
int max = 0;
if (x > y) max = x;
else max = y;
if (z > max) max = z;

Console.WriteLine(max);