Console.WriteLine("Введите число, которое нужно проверять");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (b == Math.Pow(a, 2)) Console.WriteLine($"Число {(int) a} является квадратом второго числа {(int) b}");
else {Console.WriteLine("Не является");}
