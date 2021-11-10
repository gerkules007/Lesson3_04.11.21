/* Cтруктура программы
Приветствие
Ввод команды
    Ввод числа
        Выбор задачи
            Методы решения задачи
    Ввод символа
        Помощь
        Выход
        Ошибка если нет символов
Печать полученного решения на экран
*/

// Метод ввода номера программы
void Enterprogram()
{
    Console.WriteLine("Чтобы вызвать помощь в строке введите 'h'");
    Console.WriteLine();
    System.Threading.Thread.Sleep(1000);
    bool exit = false;
    while (exit == false)
    {
        string[] command = { "Введите команду" };
        string[] commresult = { "-1" };
        InputData(command, commresult, 0, 0);
        bool check = int.TryParse(commresult[0], out int number);

        switch (check)
        {
            case true:
                Console.Write("Загружаю");
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
                Console.WriteLine();
                ChooseProgramm(commresult[0]);
                Console.WriteLine();
                System.Threading.Thread.Sleep(1000);
                break;
            case false:
                switch (commresult[0])
                {
                    case "q":
                        exit = true;
                        break;
                    case "h":
                        Console.WriteLine("Чтобы включить программу введите ее номер и нажмите Enter. Например: Для программы под номером 20, введите '20'");
                        break;
                    default:
                        Console.WriteLine("Ошибка, повторите запрос");
                        break;
                }
                break;
        }
    }
}

// Метод выбора решения программы по введенному значению
void ChooseProgramm(string task)
{
    switch (task)
    {
        case "0":
            Programm000();
            break;
        case "18":
            Programm018();
            break;
        case "19":
            Programm019();
            break;
        default:
            Console.WriteLine("Такой задачи не существует, попробуйте еще раз");
            break;
    }
}

// Метод ввода данных в вычисляемый массив (проверяет на правильность ввода данных)
void InputData(string[] firstarr, string[] secondarr, int nsi, int tool)
{
    string input = String.Empty;
    bool conduction = false;
    do
    {
        Console.WriteLine(firstarr[nsi]);
        input = Console.ReadLine()!;
        switch (tool)
        {
            case 0:
                conduction = String.IsNullOrEmpty(input);
                break;
            case 1:
                conduction = !(Double.TryParse(input, out double number) ^ String.IsNullOrEmpty(input));
                break;
        }
    } while (conduction);
    secondarr[nsi] = input;
}

bool CheckConditionForNumb(string[] c1, int index1, string[] c2, int index2, int Ncompare)
{
    bool CC = false;
    var nc1 = Int32.TryParse(c1[index1], out int result1) ? Convert.ToInt32(c1[index1]) : Convert.ToDouble(c1[index1]);
    var nc2 = Int32.TryParse(c2[index2], out int result2) ? Convert.ToInt32(c2[index2]) : Convert.ToDouble(c2[index2]);

    switch (Ncompare)
    {
        case 1:
            CC = nc1 < nc2 ? true : false;
            break;
        case 2:
            CC = nc1 <= nc2 ? true : false;
            break;
        case 3:
            CC = nc1 != nc2 ? true : false;
            break;
        case 4:
            CC = nc1 == nc2 ? true : false;
            break;
        default:
            Console.WriteLine("Uncorrect indentify CheckCondition Method. Check correct condition.");
            break;
    }
    return CC;
}

bool ToBoolean(string[] arr, int index)
{
    string input = arr[index];
    string[] trueStrings = { "1", "y", "yes", "true", "t", "верно" };
    string[] falseStrings = { "0", "n", "no", "false", "f", "не верно" };


    if (trueStrings.Contains(input.ToLower(), StringComparer.OrdinalIgnoreCase))
        return true;
    else if (falseStrings.Contains(input.ToLower(), StringComparer.OrdinalIgnoreCase))
        return false;
    else
    {
        Console.WriteLine("Uncorrect indentify boolean arguments, try again");
        return false;
    }
}
// int ToIntArray(string[] remakearray)
// {
//     int[] newarr = Array.ConvertAll<string, int>(remakearray, int.Parse);
//     return newarr;
// }

// double[] ToDoubleArray(string[] remakearray)
// {
//     double[] newarr = remakearray.Select<string, double>(s => Double.Parse(s)).ToArray<double>();
//     return newarr;
// }


double[] CreateArrayDouble(string[] array1)
{
    double[] array2 = { -1 };
    int count = array1.Length;
    Array.Resize(ref array2, count);
    return array2;
}

char[] CreateArrayToChar(string[] array1)
{
    char[] array2 = { 'E' };
    int count = array1.Length;
    Array.Resize(ref array2, count);
    return array2;
}

void PrintArrayOneLineIntoConsole(string[] printarr)
{
    Console.WriteLine(string.Join(" ", printarr));
}

void Programm000()
{
    string[] text0 = { "Введите первое число", "Введите второе число" };
    string[] arr0 = new string[text0.Length];
    for (int i0 = 0; i0 < text0.Length; i0++) InputData(text0, arr0, i0, 0);
    PrintArrayOneLineIntoConsole(arr0);
    int j0 = 0;
    if (CheckConditionForNumb(arr0, j0, arr0, j0 + 1, 1)) Console.WriteLine($"Число {arr0[0]} меньше числа {arr0[1]}");
    else { Console.WriteLine($"Число {arr0[0]} больше числа {arr0[1]}"); }
}

void Programm018()
{
    string[] text18 = { "Введите первое условие", "Введите второе условие" };
    string[] arr18 = new string[text18.Length];
    for (int i18 = 0; i18 < text18.Length; i18++) InputData(text18, arr18, i18, 0);
    bool bone = ToBoolean(arr18, 0);
    bool btwo = ToBoolean(arr18, 1);
    if ((!(bone || btwo)) == (!bone && !btwo)) Console.WriteLine($"Выражение (!( x || y)) истинно к (!x && !y)");
    else { Console.WriteLine($"Выражение (!( x || y)) ложно к (!x && !y)"); }
}

void Programm019()
{
    string[] text19 = { "Введите координаты x", "Введите координаты y" };
    string[] arr19 = new string[text19.Length];
    string[] workarr19 = { "0" };
    for (int i19 = 0; i19 < text19.Length; i19++) InputData(text19, arr19, i19, 1);
    bool checkX = CheckConditionForNumb(workarr19, 0, arr19, 0, 1);
    bool checkY = CheckConditionForNumb(workarr19, 0, arr19, 1, 1);
    Console.WriteLine($"{checkX} {checkY}");
    // case (x == 0 || y == 0):
    if (CheckConditionForNumb(workarr19, 0, arr19, 0, 4) || CheckConditionForNumb(workarr19, 0, arr19, 1, 4))
    {
        Console.Write(".");
        System.Threading.Thread.Sleep(500);
        Console.Write(".");
        System.Threading.Thread.Sleep(500);
        Console.Write(".");
        Console.WriteLine();
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("Для определение четвертей, x и y не могут быть равны 0, напишите числа заново");
    }
    else if (!(checkX ^ checkY))
    {
        // case (x > 0 && y > 0):
        if (checkX && checkY) Console.WriteLine($"Числа {arr19[0]} и {arr19[1]} находятся в I четверти");
        // case (x < 0 && y < 0):
        else { Console.WriteLine($"Числа {arr19[0]} и {arr19[1]} находятся во III четверти"); }
    }
    else
    {
        // case (x < 0 && y > 0):
        if (!checkX || checkY) Console.WriteLine($"Числа {arr19[0]} и {arr19[1]} находятся в II четверти");
        // case (x < 0 && y < 0)
        else { Console.WriteLine($"Числа {arr19[0]} и {arr19[1]} находятся во IV четверти"); }
    }
}
// Main
// Console.WriteLine("Введите свое имя");
// var name = Console.ReadLine()!;
// Console.Clear();
// System.Threading.Thread.Sleep(1000);
// Console.WriteLine($"Приветствую тебя, {name}");
// System.Threading.Thread.Sleep(2000);
Enterprogram();

