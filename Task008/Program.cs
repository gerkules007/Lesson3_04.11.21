Console.WriteLine("Введите число > 1");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < a + 1; i++) if (i % 2 == 0) { Console.Write((i) + " "); }