Console.WriteLine("Введите отрицательное число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число");
int b = Convert.ToInt32(Console.ReadLine());
int count = (-a) + b;
for (int i = 0; i < count+1; Console.Write((a) + " "), a++, i++);
