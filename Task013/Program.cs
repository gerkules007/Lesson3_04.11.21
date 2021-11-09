Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 200;
int c = b % a;
Console.WriteLine();
if (c == 0) Console.WriteLine($"Введенное число кратно начальному");
else { Console.WriteLine($"Число не кратно, введите новое, полученный остаток {c}"); }