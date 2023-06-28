string s = Console.ReadLine();

char[] dig_mas = new char[s.Length]; 
for (int i = 0; i < (s.Length); i++)
{
    dig_mas[i] = s[i];
}
Console.WriteLine(dig_mas[2]);