string[] day = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int[] weekend = {0,0,0,0,0,1,1};

void WhereIsWeekend(string[] a, int[] b, int n)
{
    int i = n - 1;
    string date = a[i];
    if (b[i] == 1) Console.WriteLine($"Введенное число {n} показывает, что {date.ToLower()} является выходным.");
    else {Console.WriteLine($"Введенное число {n} показывает, что {date.ToLower()} является рабочим днем.");}
}

Console.WriteLine("Введите число, которое нужно проверять");
int a = Convert.ToInt32(Console.ReadLine());
WhereIsWeekend(day, weekend, a);