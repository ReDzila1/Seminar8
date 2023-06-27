int[] array = {122, 221, 325212, 25, 61, 7,822, 9, 421};
int n = array.Length;
int find = 822;
for (int index = 0; index < (n - 1); index++)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        index = n;
    }
}