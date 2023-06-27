int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 121;
int b1 = 72;
int c1 = 443;

int a2 = 47;
int b2 = 92;
int c2 = 258; 

int a3 = 1102;
int b3 = 22;
int c3 = 1;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

Console.WriteLine(Max(max1, max2, max3));