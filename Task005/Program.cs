double Function(double x)
{
    double y = Math.Sin(x) + 10;
    return y;
}
Console.WriteLine("Введите число x");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Ваш ответ {Function(a):F2}");
