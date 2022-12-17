Console.WriteLine("Введите число A ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C ");
int c = Convert.ToInt32(Console.ReadLine());

int x = b;

if (a > b)
{
    x = a;
}



if (b > c)
{
    x = b;
}
else
{
    x = c;
}


Console.WriteLine("max=" + x);