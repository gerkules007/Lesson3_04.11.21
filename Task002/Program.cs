Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) Console.WriteLine($"Число {(int) a} больше числа {(int) b}");
else {Console.WriteLine($"Число {(int) a} меньше или равно числу {(int) b}");}

