Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 10;
int c = a % 1000 / 100;
int result = c * 100 + b;
Console.WriteLine($"Преобразованное число {result}");
