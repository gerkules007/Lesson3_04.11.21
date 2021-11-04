int Function(int x)
{
    int y = x * x + 10;
    return y;
}
Console.WriteLine("Введите число x");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ваш ответ {Function(a)}");
