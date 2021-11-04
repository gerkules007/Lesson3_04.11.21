Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 10;
Console.WriteLine($"Последняя цифра трехзначного числа {b}");
int c = a % 100 /10;
Console.WriteLine($"Вторая цифра трехзначного числа {c}");