void Compare3(int n)
{
    if (100 <= n)
    {
        int b = n % 1000 / 100;
        Console.WriteLine($"Третья цифра числа равна {b}");
    }
    else
    {
        Console.WriteLine($"Число меньше трехзначного");
    }
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Compare3(a);
Console.WriteLine();