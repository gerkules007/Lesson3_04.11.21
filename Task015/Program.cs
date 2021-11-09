void Capacity(int a, int b, int c)
{
    int change = -1;
    if (a % b == 0) change = 1;
    else if (a % c == 0) change = 2;
    else if ((a % b == 0) && (a % c == 0)) change = 3;
    switch (change)
    {
        case 1:
            Console.WriteLine($"Число кратно {b}");
            break;
        case 2:
            Console.WriteLine($"Число кратно {c}");
            break;
        case 3:
            Console.WriteLine($"Число кратно и {b}, и {c}");
            break;
        default:
            Console.WriteLine($"Число не кратно, введите новое");
            break;
    }
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 7;
int c = 23;
Capacity(a, b, c);