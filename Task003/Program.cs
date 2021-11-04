string n1 = "Понедельник";
string n2 = "Вторник";
string n3 = "Среда";
string n4 = "Четверг";
string n5 = "Пятница";
string n6 = "Суббота";
string n7 = "Воскресенье";

void DisplayMeasurement(int a)
{
    switch (a)
    {
        case 1:
            Console.WriteLine($"Вы ввели день недели: {(string) n1}");
            break;

        case 2:
            Console.WriteLine($"Вы ввели день недели: {(string) n2}");
            break;

        case 3:
            Console.WriteLine($"Вы ввели день недели: {(string) n3}");
            break;

        case 4:
            Console.WriteLine($"Вы ввели день недели: {(string) n4}");
            break;

        case 5:
            Console.WriteLine($"Вы ввели день недели: {(string) n5}");
            break;

        case 6:
            Console.WriteLine($"Вы ввели день недели: {(string) n6}");
            break;
        
        case 7:
            Console.WriteLine($"Вы ввели день недели: {(string) n7}");
            break;

        default:
            Console.WriteLine("Ошибка, ввели не ту переменную");
            break;
    }
}

Console.WriteLine("Введите число, которое нужно проверять");
int a = Convert.ToInt32(Console.ReadLine());
DisplayMeasurement(a);

