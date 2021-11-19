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
                System.Threading.Thread.Sleep(400);
                Console.Write(".");
                System.Threading.Thread.Sleep(400);
                Console.Write(".");
                System.Threading.Thread.Sleep(400);
                Console.Write(".");
                Console.WriteLine();
                Console.Clear();
                ChooseProgramm(commresult[0]);
                Console.WriteLine();
                System.Threading.Thread.Sleep(500);
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
        case "20":
            Programm020();
            break;
        case "21":
            Programm021();
            break;
        case "22":
            Programm022();
            break;
        case "23":
            Programm023();
            break;
        case "24":
            Programm024();
            break;
        case "25":
            Programm025();
            break;
        case "26":
            Programm026();
            break;
        case "27":
            Programm027028();
            break;
        case "28":
            Programm027028();
            break;
        default:
            Console.WriteLine("Такой задачи не существует, попробуйте еще раз");
            break;
    }
}

string[] Start(string[] inputStr, string[] newArr)
{
    Console.WriteLine(inputStr[1]);
    System.Threading.Thread.Sleep(2000);
    switch (newArr[0])
    {
        case "Random":
            int minVal = Int32.TryParse(newArr[1], out int outnumber1) ? Convert.ToInt32(outnumber1) : default;
            int maxVal = Int32.TryParse(newArr[2], out int outnumber2) ? Convert.ToInt32(outnumber2) : default;
            Random rand = new Random();
            int countNewArr = Int32.TryParse(newArr[3], out int outnumber3) ? Convert.ToInt32(outnumber3) : default;
            newArr = new string[countNewArr];
            for (int i = 0; i < inputStr.Length - 1; i++) newArr[i] = Convert.ToString(rand.Next(minVal, maxVal));
            break;
        case "String":
            newArr = InputData(inputStr, 0);
            break;
        case "Double":
            newArr = InputData(inputStr, 1);
            break;
        case "Int32":
            newArr = InputData(inputStr, 2);
            break;
        case "Int64":
            newArr = InputData(inputStr, 3);
            break;
        default:
            Console.WriteLine("Error, check input data");
            break;
    }
    return newArr;
}


// Метод ввода данных в вычисляемый массив (проверяет на правильность ввода данных)
string[] InputData(string[] firstarr, int tool)
{
    string[] secondarr = new string[firstarr.Length];
    for (int inputI = 1; inputI < firstarr.Length; inputI++)
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
                    conduction = !(Int64.TryParse(inputdata, out long outnumber3) ^ String.IsNullOrEmpty(inputdata));
                    break;
                case 4:
                    conduction = !((Int32.TryParse(inputdata, out int outnumber4) && 10000 <= outnumber4 && outnumber4 < 100000) ^ String.IsNullOrEmpty(inputdata));
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

void WriteResult(string conductionResult, string result, int toolwrite)
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

double[] ToDoubleArray(string[] remakearray)
{
    double[] newarr = remakearray.Select<string, double>(s => Double.Parse(s)).ToArray<double>();
    return newarr;
}

int[] ToIntArrayFromString(string inputStr)
{
    int leng = inputStr.Length;
    int[] outputArr;
    if (inputStr[0] == '-')
    {
        outputArr = new int[leng - 1];
        for (int i = 1; i < leng; i++) outputArr[i - 1] = int.Parse(inputStr[i].ToString());
    }
    else
    {
        outputArr = new int[leng];
        for (int i = 0; i < leng; i++) outputArr[i] = int.Parse(inputStr[i].ToString());
    }
    return outputArr;
}
// double[] CreateArrayDouble(string[] array1)
// {
//     double[] array2 = { -1 };
//     int count = array1.Length;
//     Array.Resize(ref array2, count);
//     return array2;
// }

void CreateArrayDoubleRange(double[] doubleArray, string minCount, string maxCount)
{
    int minCAI = Convert.ToInt32(minCount);
    int maxCAI = Convert.ToInt32(maxCount);
    int CountIndex = (maxCAI - minCAI) / (doubleArray.Length - 1);
    doubleArray[0] = minCAI;
    for (int iCAI = 1; iCAI < doubleArray.Length; iCAI++) doubleArray[iCAI] += CountIndex;
}

string CreateStringAsArray(double[] doubleArr)
{
    string newString = String.Empty;
    for (int iCAS = 0; iCAS < doubleArr.Length; iCAS++) newString += $"{doubleArr[iCAS]} ";
    return newString;
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

string[] SeparateArray(string separateArr)
{
    string[] newSA = new string[separateArr.Length];
    string result = string.Empty;
    for (int iSA = 0, jSA = 0; iSA < separateArr.Length; iSA++)
    {
        if (separateArr[iSA] == ' ')
        { newSA[jSA++] = result; result = string.Empty; }
        else result += $"{separateArr[iSA]}";
    }
    return newSA;
}

void PrintArrayIntoConsole(string[] printarr, int printset)
{
    switch (printset)
    {
        case 0:
            Console.WriteLine(string.Join(" ", printarr));
            break;
        case 1:
            foreach (string print in printarr) Console.WriteLine(print);
            break;
    }
}

void Programm000()
{
    string[] text0 = { "Введите первое число", "Введите второе число" };
    string[] arr0 = InputData(text0, 0);
    PrintArrayIntoConsole(arr0, 0);
    int j0 = 0;
    if (CheckConditionForNumb(arr0[j0], arr0[j0 + 1], 1)) Console.WriteLine($"Число {arr0[0]} меньше числа {arr0[1]}");
    else { Console.WriteLine($"Число {arr0[0]} больше числа {arr0[1]}"); }
}

void Programm018()
{
    Console.WriteLine("Задание: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y");
    System.Threading.Thread.Sleep(2000);
    string[] text18 = { "Введите первое условие", "Введите второе условие" };
    string[] arr18 = InputData(text18, 0);

    bool bone = ToBoolean(arr18, 0);
    bool btwo = ToBoolean(arr18, 1);
    if ((!(bone || btwo)) == (!bone && !btwo)) Console.WriteLine($"Выражение (!( x || y)) истинно к (!x && !y)");
    else { Console.WriteLine($"Выражение (!( x || y)) ложно к (!x && !y)"); }
}

void Programm019()
{
    Console.WriteLine("Задание: Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0");
    System.Threading.Thread.Sleep(2000);
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
    Console.WriteLine("Задание: Ввести номер четверти, показать диапазоны для возможных координат");
    System.Threading.Thread.Sleep(2000);
    string[] text20 = { "Number of quarter" };
    string[] arr20 = InputData(text20, 1);

    string[] instruction20 = { "1 quater", "2 quater", "3 quater", "4 quater" };
    string[] result20 = { "x = (0, +infinity), y = (0, +infinity)", "x = (-infinity, 0), y = (0, +infinity)", "x = (-infinity, 0), y = (-infinity, 0)", "x = (0, +infinity), y = (-infinity, 0)" };
    switch (arr20[0])
    {
        case "1":
            WriteResult(instruction20[0], result20[0], 0);
            break;
        case "2":
            WriteResult(instruction20[1], result20[1], 0);
            break;
        case "3":
            WriteResult(instruction20[2], result20[2], 0);
            break;
        case "4":
            WriteResult(instruction20[3], result20[3], 0);
            break;
        default:
            Console.WriteLine("Uncorrect indentify quater. Check correct number.");
            break;
    }
}
void Programm021()
{
    Console.WriteLine("Задание: Проверить пятизначное число на палидром");
    System.Threading.Thread.Sleep(2000);
    string[] text21 = { "Palindrome" };
    string[] arr21 = InputData(text21, 4);

    string newstring21 = Reverse(arr21[0]);
    if (CheckConditionForNumb(arr21[0], newstring21, 4)) WriteResult(arr21[0], text21[0], 0);
    else { WriteResult(arr21[0], text21[0], 1); }
}

void Programm022()
{
    Console.WriteLine("Задание: Найти расстояние между точкамами в пространстве 2D/3D");
    System.Threading.Thread.Sleep(2000);
    string[] text22 = { "X.1", "Y.1", "Z.1", "X.2", "Y.2", "Z.2" };
    string resulttext22 = "Distanse of two dots";
    string[] arr22 = InputData(text22, 1);

    double[] changearr22 = ToDoubleArray(arr22);
    int i22 = 0;
    // result = корень из (x1-x2)^2 + (y1-y2)^2
    string result22 = Convert.ToString(Math.Round(Math.Sqrt(Math.Pow((changearr22[i22] - changearr22[i22 + 3]), 2) + Math.Pow((changearr22[i22 + 1] - changearr22[i22 + 4]), 2) + Math.Pow((changearr22[i22 + 2] - changearr22[i22 + 5]), 2)), 2));
    WriteResult(resulttext22, result22, 0);
}

void Programm023()
{
    Console.WriteLine("Показать таблицу квадратов чисел от 1 до N");
    System.Threading.Thread.Sleep(2000);
    string[] text23 = { "N number" };
    string[] arr23 = InputData(text23, 2);

    int i23 = 0;
    string start23 = "1";
    int maxcount23 = Convert.ToInt32(arr23[i23]) - Convert.ToInt32(start23);
    double[] newArr23 = new double[maxcount23];
    CreateArrayDoubleRange(newArr23, start23, arr23[i23]);
    double[] arrResult23 = new double[newArr23.Length];
    for (i23 = 0; i23 < arrResult23.Length; i23++)
    {
        arrResult23[i23] = Math.Pow(newArr23[i23], 2);
        WriteResult(Convert.ToString(newArr23[i23]), Convert.ToString(arrResult23[i23]), 0);
    }
}

void Programm024()
{
    string task24 = "Найти кубы чисел от 1 до N";
    Console.WriteLine(task24);
    System.Threading.Thread.Sleep(2000);
    string[] text24 = { "N number" };
    string[] arr24 = InputData(text24, 2);

    int i24 = 0;
    string start24 = "1";
    int maxcount24 = Convert.ToInt32(arr24[i24]) - Convert.ToInt32(start24);
    double[] newArr24 = new double[maxcount24];
    CreateArrayDoubleRange(newArr24, start24, arr24[i24]);
    double[] arrResult24 = new double[newArr24.Length];
    for (i24 = 0; i24 < arrResult24.Length; i24++) arrResult24[i24] = Math.Pow(newArr24[i24], 3);
    task24 = $"Найти кубы чисел от 1 до {arr24[0]}";
    WriteResult(task24, CreateStringAsArray(arrResult24), 0);
}

void Programm025()
{
    string task25 = "Найти сумму чисел от 1 до А";
    Console.WriteLine(task25);
    System.Threading.Thread.Sleep(2000);
    string[] text25 = { "A number" };
    string[] arr25 = InputData(text25, 2);

    int i25 = 0;
    string start25 = "1";
    int maxcount25 = Convert.ToInt32(arr25[i25]) - Convert.ToInt32(start25);
    double[] newArr25 = new double[maxcount25];
    CreateArrayDoubleRange(newArr25, start25, arr25[i25]);
    double summ = 0;
    for (; i25 < newArr25.Length; i25++) summ += newArr25[i25];
    task25 = $"Найти сумму чисел от 1 до {arr25[0]}";
    WriteResult(task25, Convert.ToString(summ), 0);
}

void Programm026()
{
    string task26 = "Возведите число А в натуральную степень B, используя цикл";
    Console.WriteLine(task26);
    System.Threading.Thread.Sleep(2000);
    string[] text26 = { "A number", "B number" };
    string[] arr26 = InputData(text26, 2);

    int i26 = 0;
    int maxcount26 = Convert.ToInt32(arr26[i26 + 1]);
    double[] newArr26 = new double[maxcount26];
    CreateArrayDoubleRange(newArr26, arr26[i26], arr26[i26]);
    double multiplication26 = 1;
    for (i26 = 0; i26 < newArr26.Length; i26++) multiplication26 *= newArr26[i26];
    WriteResult($"{arr26[0]} in {arr26[1]}", Convert.ToString(multiplication26), 0);
}

void Programm027028()
{
    // Перевод числа из строки в символы, а затем в цифры
    // сумма всех чисел и печать

    Console.WriteLine("Определить количество цифр в цифре и посчитать сумму цифр в цифре");
    System.Threading.Thread.Sleep(2000);
    string[] text27 = { "Number" };
    string[] arr27 = InputData(text27, 2);

    int summ = 0;
    int[] numb27 = ToIntArrayFromString(arr27[0]);
    foreach (int n in numb27) summ += n;
    WriteResult("count numb", $"{numb27.Length}", 0);
    WriteResult("summ numb", $"{summ}", 0);
}

void Programm029()
{
    Console.WriteLine("Написать программу вычисления чисел от 1 до N");
    System.Threading.Thread.Sleep(2000);
    string[] text29 = { "Number" };
    string[] arr29 = InputData(text29, 2);
    string start29 = "1";



}

void Programm030()
{
    Console.WriteLine("Показать кубы чисел, заканчивающихся на четную цифру");
    double[] arr30 = new double[10];
    Random rand = new Random();
    foreach (int numb in arr30)
        for (int i = 0; i < arr30.Length; i++) if (arr30[i] % 2 == 0) Console.WriteLine(Math.Pow(arr30[i], 3));
}

void Programm035()
{
    string[] text35 = { "Определить присутствует ли в заданном массиве некоторое число", "Number" };
    string[] conduction35 = { "Int64" };
    string[] newArr35 = Start(text35, conduction35);
}

// Main
// Console.WriteLine("Введите свое имя");
// var name = Console.ReadLine()!;
// Console.Clear();
// int sleep1 = 1000;
// System.Threading.Thread.Sleep(1000);
// Console.WriteLine($"Приветствую тебя, {name}");
// System.Threading.Thread.Sleep(2000);
Enterprogram();


