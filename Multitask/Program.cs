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
        string[] commresult = InputData(command, 0);
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
                Console.Clear();
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
            Console.WriteLine("Задание: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y");
            System.Threading.Thread.Sleep(2000);
            Programm018();
            break;
        case "19":
            Console.WriteLine("Задание: Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0");
            System.Threading.Thread.Sleep(2000);
            Programm019();
            break;
        case "20":
            Console.WriteLine("Задание: Ввести номер четверти, показать диапазоны для возможных координат");
            System.Threading.Thread.Sleep(2000);
            Programm020();
            break;
        case "21":
            Console.WriteLine("Задание: Проверить пятизначное число на палидром");
            System.Threading.Thread.Sleep(2000);
            Programm021();
            break;
        default:
            Console.WriteLine("Такой задачи не существует, попробуйте еще раз");
            break;
    }
}

// Метод ввода данных в вычисляемый массив (проверяет на правильность ввода данных)
string[] InputData(string[] firstarr, int tool)
{
    string[] secondarr = new string[firstarr.Length];
    for (int inputI = 0; inputI < firstarr.Length; inputI++)
    {
        string inputdata = String.Empty;
        bool conduction = false;
        do
        {
            Console.WriteLine(firstarr[inputI]);
            inputdata = Console.ReadLine()!;
            switch (tool)
            {
                case 0:
                    conduction = String.IsNullOrEmpty(inputdata);
                    break;
                case 1:
                    conduction = !(Double.TryParse(inputdata, out double outnumber) ^ String.IsNullOrEmpty(inputdata));
                    break;
                case 2:
                    conduction = !(Int32.TryParse(inputdata, out int outnumber2) ^ String.IsNullOrEmpty(inputdata));
                    break;
                case 3:
                    conduction = !((Int32.TryParse(inputdata, out int outnumber3) && 10000 <= outnumber3 && outnumber3 < 100000) ^ String.IsNullOrEmpty(inputdata));
                    break;
            }
        } while (conduction);
        secondarr[inputI] = inputdata;
    }
    return secondarr;
}

bool CheckConditionForNumb(string c1, string c2, int Ncompare)
{
    bool CC = false;
    var nc1 = Int32.TryParse(c1, out int result1) ? Convert.ToInt32(c1) : Convert.ToDouble(c1);
    var nc2 = Int32.TryParse(c2, out int result2) ? Convert.ToInt32(c2) : Convert.ToDouble(c2);

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

void WriteCondition(string conductionResult, string result, int toolwrite)
{
    switch (toolwrite)
    {
        case 0:
            Console.WriteLine($"Result for {conductionResult} = {result}");
            break;
        case 1:
            Console.WriteLine($"Result for {conductionResult} not = {result}");
            break;
    }
}

int[] ToIntArray(string[] remakearray)
{
    int[] newarr = Array.ConvertAll<string, int>(remakearray, int.Parse);
    return newarr;
}

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

string Reverse(string inputReverse)
{
    string outputReverse = String.Empty;
    for (int ir = inputReverse.Length - 1; ir >= 0; ir--)
    {
        outputReverse += inputReverse[ir];
    }
    return outputReverse;
}

void PrintArrayOneLineIntoConsole(string[] printarr)
{
    Console.WriteLine(string.Join(" ", printarr));
}

void Programm000()
{
    string[] text0 = { "Введите первое число", "Введите второе число" };
    string[] arr0 = InputData(text0, 0);
    PrintArrayOneLineIntoConsole(arr0);
    int j0 = 0;
    if (CheckConditionForNumb(arr0[j0], arr0[j0 + 1], 1)) Console.WriteLine($"Число {arr0[0]} меньше числа {arr0[1]}");
    else { Console.WriteLine($"Число {arr0[0]} больше числа {arr0[1]}"); }
}

void Programm018()
{
    string[] text18 = { "Введите первое условие", "Введите второе условие" };
    string[] arr18 = InputData(text18, 0);
    bool bone = ToBoolean(arr18, 0);
    bool btwo = ToBoolean(arr18, 1);
    if ((!(bone || btwo)) == (!bone && !btwo)) Console.WriteLine($"Выражение (!( x || y)) истинно к (!x && !y)");
    else { Console.WriteLine($"Выражение (!( x || y)) ложно к (!x && !y)"); }
}

void Programm019()
{
    string[] text19 = { "Введите координаты x", "Введите координаты y" };
    string[] arr19 = InputData(text19, 1);
    string[] workarr19 = { "0" };
    bool checkX = CheckConditionForNumb(workarr19[0], arr19[0], 1);
    bool checkY = CheckConditionForNumb(workarr19[0], arr19[1], 1);
    Console.WriteLine($"{checkX} {checkY}");
    // case (x == 0 || y == 0):
    if (CheckConditionForNumb(workarr19[0], arr19[0], 4) || CheckConditionForNumb(workarr19[0], arr19[1], 4))
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

void Programm020()
{
    string[] text20 = { "Number of quarter" };
    string[] arr20 = InputData(text20, 1);
    string[] instruction20 = { "1 quater", "2 quater", "3 quater", "4 quater" };
    string[] result20 = { "x = (0, +infinity), y = (0, +infinity)", "x = (-infinity, 0), y = (0, +infinity)", "x = (-infinity, 0), y = (-infinity, 0)", "x = (0, +infinity), y = (-infinity, 0)" };
    switch (arr20[0])
    {
        case "1":
            WriteCondition(instruction20[0], result20[0], 0);
            break;
        case "2":
            WriteCondition(instruction20[1], result20[1], 0);
            break;
        case "3":
            WriteCondition(instruction20[2], result20[2], 0);
            break;
        case "4":
            WriteCondition(instruction20[3], result20[3], 0);
            break;
        default:
            Console.WriteLine("Uncorrect indentify quater. Check correct number.");
            break;
    }
}
void Programm021()
{
    string[] text21 = { "Palindrome" };
    string[] arr21 = InputData(text21, 3);
    string newstring21 = Reverse(arr21[0]);
    if (CheckConditionForNumb(arr21[0], newstring21, 4)) WriteCondition(arr21[0], text21[0], 0);
    else {WriteCondition(arr21[0], text21[0], 1);}
}

void Programm022()
{
    
}
// Main
// Console.WriteLine("Введите свое имя");
// var name = Console.ReadLine()!;
// Console.Clear();
// System.Threading.Thread.Sleep(1000);
// Console.WriteLine($"Приветствую тебя, {name}");
// System.Threading.Thread.Sleep(2000);
Enterprogram();

