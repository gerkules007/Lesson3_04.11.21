int RangeNumber(long num)
{
    int k = 0;
    while (num != 0)
    {
        k++;
        num = num / 10;
    }
    return k;
}

void Compare3(long n, int count)
{
    if (count < 3) Console.WriteLine($"Число меньше трехзначного");
    else
    {
        int c = Convert.ToInt32(n / 100);
        Console.WriteLine($"Третья цифра числа равна {c}");
    }
}

Console.WriteLine("Введите число");
long a = Convert.ToInt32(Console.ReadLine());
int b = RangeNumber(a);
Compare3(a, b);