void PowNumbers(int n1, int n2)
{
    if (n1 == Math.Pow(n2, 2))
    {
        Console.WriteLine($"Число {(int)n1} является квадратом второго числа {(int)n2}");
    }
    else if (n2 == Math.Pow(n1, 2))
    {
        Console.WriteLine($"Число {(int)n2} является квадратом первого числа {(int)n1}");
    }
    else
    {
        Console.WriteLine("Не является друг другу квадратами");
    }
}

Console.WriteLine("Введите число, которое нужно проверять");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
PowNumbers(a, b);