int RangeNumber(int num)
{
    int k = 0;
    while (num != 0)
    {
        k++;
        num = num / 10;
    }
    return k;
}

void Compare3(int n, int count)
{
    if (count < 3) Console.WriteLine($"Число меньше трехзначного");
    else
    {
        int c = n / 100;
        Console.WriteLine($"Третья цифра числа равна {c}");
    }
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = RangeNumber(a);
Compare3(a, b);