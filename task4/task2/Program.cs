int a = 2;
int b = 10;
int max = 0;
int min = 0;

if (a > b)
{
    max = a;
    min = b;
}

if (a < b)
{
    max = b;
    min = a;
}
Console.WriteLine(max);
Console.WriteLine(min);
