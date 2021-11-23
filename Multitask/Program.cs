/* Алгоритм программы
Приветствие
Ввод команды
    Ввод числа
        Выбор задачи
            Методы решения задачи
    Ввод символа
        Помощь
        Выход
        Изменение входных парметров программы
        Ошибка если нет символов
Печать результата
*/

/* Структура программы
Приветствие
Ввод команды
    Ввод числа
    Ввод символа
        Помощь
        Выход
        Изменение входных парметров выбранной минипрограммы
        Ошибка если нет символов
Запуск программы
    Номер программы
Метод Введение данных
Метод Начального запуска программы
Метод Рандомного числа
Метод Печати массива
Методы перевода string в int, double
Печать полученного решения на экран
*/


// Метод ввода номера программы
void Enterprogram()
{
    Console.WriteLine("Чтобы вызвать помощь в строке введите 'h'");
    Console.WriteLine();
    System.Threading.Thread.Sleep(500);
    bool exit = false;
    while (exit == false)
    {
        Console.Clear();
        string comm = String.Empty;
        string[] command = { "Введите команду" };
        InputData(command, "string");

        bool check = int.TryParse(command[0], out int number);
        if (check == false) comm = command[0].ToUpper();
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
                do
                {
                    System.Threading.Thread.Sleep(500);
                    ChooseProgramm(command[0]);
                    Console.WriteLine();
                    Console.WriteLine("Запустить заново? Y/N");
                } while (Console.ReadKey(true).Key != ConsoleKey.N);
                break;
            case false:
                switch (comm)
                {
                    case "Q":
                        exit = true;
                        break;
                    case "H":
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
        case "29":
            Programm029();
            break;
        case "30":
            Programm030();
            break;
        case "35":
            Programm035();
            break;
        default:
            Console.WriteLine("Такой задачи не существует, попробуйте еще раз");
            break;
    }
}

/*
Данные даны и вводить ничего не нужно
Данные нужно задавать через консоль и они будут применяться к методам
Данные вводятся вручную
Данные будут импортироваться из файла

*/
/* Метод выбора массива, Какие данные введены, Ввод необходимых параметров, последний элемент: начальное приветствие
string[] settings = {"Приветствие", "Random", "Int32"};
string[] newArr = {"Введите минимальные значения", "Введите максимальные значения", "Введите количество"};
string[] settings = {"Приветствие", "Random", "Int32"};
string[] newArr = {"10", "15", "10"};
string[] settings = {"Приветствие", "Enter", "Int32"};
string[] newArr = {"Первое число, второе число"};
string[] settings = {"Приветствие", "Enter", "Int32"};
string[] newArr = {"10", "15", "10", "15", "10"};
string[] settings = {"Приветствие", "Import", "String"};
string[] newArr = {"Введите путь"};
string[] settings = {"Приветствие", "Import", "String"};
string[] newArr = {"E\"};

*/
void Start(string[] inputSet, ref string[] inputArr)
{
    Console.Clear();
    Console.WriteLine(inputSet[0]);
    System.Threading.Thread.Sleep(2000);
    int lengSet = inputSet.Length;
    int lengNew = inputArr.Length;
    bool inputresult = Double.TryParse(inputArr[0], out double outnumb);
    string set = inputSet[1].ToUpper();
    switch (set)
    {
        case "RANDOM":
            if (!inputresult) InputData(inputArr, inputSet[2]);
            Random(ref inputArr);
            break;
        case "ENTER":
            InputData(inputArr, inputSet[2]);
            break;
        case "IMPORT":
            if (FindSymbol(inputArr[0], ':', out int pos) && pos == 3) InputData(inputArr, inputSet[2]);
            GetImportData(inputArr[0]);
            break;
        case "DEFAULT":
            InputData(inputArr, inputSet[2]);
            CreateArrayRangeInt32(ref inputArr);
            break;
        default:
            Console.WriteLine("Error, check kind of method input: Random, Enter, Default, Import");
            break;
    }
}

void Random(ref string[] inputArr)
{
    bool boolMinVal = Int32.TryParse(inputArr[0], out int outnumber1);
    bool boolMaxVal = Int32.TryParse(inputArr[1], out int outnumber2);
    int countNewArr = Int32.TryParse(inputArr[2], out int outnumber3) ? Convert.ToInt32(outnumber3) : 1;
    Random rand = new Random();
    if (boolMinVal && boolMaxVal)
    {
        int minVal = Convert.ToInt32(inputArr[0]);
        int maxVal = Convert.ToInt32(inputArr[1]);
        Array.Resize(ref inputArr, countNewArr);
        if (maxVal == minVal) maxVal = minVal + 1;
        for (int i = 0; i < countNewArr; i++) inputArr[i] = Convert.ToString(rand.Next(minVal, maxVal));
    }
    else
    {
        int countMinNumbValue = GetIntergerNumericalPosition(inputArr[0]);
        int countMaxNumbValue = GetIntergerNumericalPosition(inputArr[1]);
        int countRange = countMinNumbValue < countMaxNumbValue ? countMaxNumbValue : countMinNumbValue;
        double minValue = Convert.ToDouble(inputArr[0]);
        double maxValue = Convert.ToDouble(inputArr[1]);
        Array.Resize(ref inputArr, countNewArr);
        double range = maxValue - minValue != 0 ? maxValue - minValue : maxValue;
        double numb = 0;
        for (int i = 0; i < countNewArr; i++)
        {
            numb = Math.Round(rand.NextDouble(), countRange);
            numb *= range;
            numb += minValue;
            inputArr[i] = Convert.ToString(Math.Round(numb));
        }
    }
}

int GetIntergerNumericalPosition(string numb)
{
    int position = numb.Length;
    position = FindSymbol(numb, '.', out int posit1) ? position = posit1 - 1 : position;
    position = FindSymbol(numb, '-', out int posit2) ? position = position - 1 : position;
    return position;
}

bool FindSymbol(string inputNumb, char needSymbol, out int position)
{
    bool boolPosition = false;
    position = -1;
    for (int i = 0; i < inputNumb.Length; i++) if (inputNumb[i] == needSymbol) { boolPosition = true; position = i; break; }
    return boolPosition;
}

string[] GetImportData(string place)
{
    string[] input = System.IO.File.ReadAllLines(place);
    return input;
}

// Метод ввода данных в вычисляемый массив (проверяет на правильность ввода данных)
void InputData(string[] inputArr, string tool)
{
    string[] toolArr = MakeStringToStringArray(tool, ',');
    int countOrder = int.MaxValue;
    if (toolArr.Length > 1) { countOrder = int.TryParse(toolArr[toolArr.Length - 1], out int inputCount) ? inputCount : countOrder; }
    string toolUpper = toolArr[0].ToUpper();
    string inputdata = String.Empty;
    for (int inputI = 0; inputI < inputArr.Length; inputI++)
    {
        if (!Double.TryParse(inputArr[inputI], out double outnumber))
        {
            bool conduction = false;
            do
            {
                do
                {
                    Console.WriteLine(inputArr[inputI]);
                    inputdata = Console.ReadLine()!;
                }
                while (!(String.IsNullOrEmpty(inputdata) ^ GetIntergerNumericalPosition(inputdata) <= countOrder));

                switch (toolUpper)
                {
                    case "STRING":
                        conduction = false;
                        break;
                    case "DOUBLE":
                        conduction = !(Double.TryParse(inputdata, out double outnumber1));
                        break;
                    case "INT32":
                        conduction = !(Int32.TryParse(inputdata, out int outnumber2));
                        break;
                    case "INT64":
                        conduction = !(Int64.TryParse(inputdata, out long outnumber3));
                        break;
                    case "INT32RANGE":
                        conduction = !(Int32.TryParse(inputdata, out int outnumber4) && outnumber4 < int.MaxValue / 2 && outnumber4 > int.MinValue / 2);
                        break;
                    case "PLACE":
                        conduction = !(FindSymbol(inputArr[inputI], '.', out int c));
                        inputdata = "@" + $"{inputdata}";
                        break;
                    default:
                        Console.WriteLine("Uncorrect indefy format, please enter correct format of input values");
                        conduction = false;
                        break;
                }
            } while (conduction);
            inputArr[inputI] = inputdata;
        }
    }
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

void CreateArrayRangeInt32(ref string[] inputArr)
{
    int minCAI = Convert.ToInt32(inputArr[0]);
    int maxCAI = Convert.ToInt32(inputArr[1]);
    int RangeIndex = Convert.ToInt32(maxCAI - minCAI);
    Array.Resize(ref inputArr, RangeIndex);
    for (uint iCAI = 0; iCAI < inputArr.Length; iCAI++) inputArr[iCAI] = Convert.ToString(minCAI++);
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

string[] MakeStringToStringArray(string separateArr, char separateChar)
{
    string[] newSA = new string[1];
    string result = string.Empty;
    int countArr = 1;
    for (int iSA = 0, jSA = 0; iSA < separateArr.Length; iSA++)
    {
        if (separateArr[iSA] == separateChar)
        {
            Array.Resize(ref newSA, countArr + 1);
            newSA[jSA++] = result;
            result = string.Empty;
        }
        else result += $"{separateArr[iSA]}";
    }
    newSA[newSA.Length - 1] = result;
    return newSA;
}

string StringResult(string[] printarr)
{
    return string.Join(" ", printarr);
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
    
    // string[] settings5 = { "Приветствие", "IMPORT", "PLACE" };
    // string[] Arr5 = { @"C:\Users\ovcse\Desktop\РАЗРАБОТЧИК\СЕМИНАРЫ\in CS\Lesson4\17.txt" };
    // Start(settings, Arr5);
    // Console.WriteLine(Arr5[0][0] + Arr5[0][1] + Arr5[0][2]);
    // Console.ReadKey();

    // int j0 = 0;
    // if (CheckConditionForNumb(arr0[j0], arr0[j0 + 1], 1)) Console.WriteLine($"Число {arr0[0]} меньше числа {arr0[1]}");
    // else { Console.WriteLine($"Число {arr0[0]} больше числа {arr0[1]}"); }
}

void Programm018()
{
    string[] start18 = { "Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y", "Enter", "string" };
    string[] currArr18 = { "Введите первое условие", "Введите второе условие" };

    bool bone = ToBoolean(currArr18, 0);
    bool btwo = ToBoolean(currArr18, 1);
    if ((!(bone || btwo)) == (!bone && !btwo)) Console.WriteLine($"Выражение (!( x || y)) истинно к (!x && !y)");
    else { Console.WriteLine($"Выражение (!( x || y)) ложно к (!x && !y)"); }
}

void Programm019()
{
    string[] start19 = { "Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0", "Enter", "double" };
    string[] currArr19 = { "Введите координаты x", "Введите координаты y" };
    Start(start19, ref currArr19);
    string[] workarr19 = { "0" };

    bool checkX = CheckConditionForNumb(workarr19[0], currArr19[0], 1);
    bool checkY = CheckConditionForNumb(workarr19[0], currArr19[1], 1);
    Console.WriteLine($"{checkX} {checkY}");
    // case (x == 0 || y == 0):
    if (CheckConditionForNumb(workarr19[0], currArr19[0], 4) || CheckConditionForNumb(workarr19[0], currArr19[1], 4))
    {
        Console.Write("."); System.Threading.Thread.Sleep(500); Console.Write("."); System.Threading.Thread.Sleep(500); Console.Write("."); Console.WriteLine();
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("Для определение четвертей, x и y не могут быть равны 0, напишите числа заново");
    }
    else if (!(checkX ^ checkY))
    {
        // case (x > 0 && y > 0):
        if (checkX && checkY) Console.WriteLine($"Числа {currArr19[0]} и {currArr19[1]} находятся в I четверти");
        // case (x < 0 && y < 0):
        else { Console.WriteLine($"Числа {currArr19[0]} и {currArr19[1]} находятся во III четверти"); }
    }
    else
    {
        // case (x < 0 && y > 0):
        if (!checkX || checkY) Console.WriteLine($"Числа {currArr19[0]} и {currArr19[1]} находятся в II четверти");
        // case (x < 0 && y < 0)
        else { Console.WriteLine($"Числа {currArr19[0]} и {currArr19[1]} находятся во IV четверти"); }
    }
}

void Programm020()
{
    string[] start20 = { "Ввести номер четверти, показать диапазоны для возможных координат", "Enter", "int32,1" };
    string[] currArr20 = { "Number of quarter" };
    Start(start20, ref currArr20);

    string[] instruction20 = { "1 quater", "2 quater", "3 quater", "4 quater" };
    string[] result20 = { "x = (0, +infinity), y = (0, +infinity)", "x = (-infinity, 0), y = (0, +infinity)", "x = (-infinity, 0), y = (-infinity, 0)", "x = (0, +infinity), y = (-infinity, 0)" };
    switch (currArr20[0])
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
    string[] start21 = { "Проверить пятизначное число на палидром", "Enter", "int32,5" };
    string[] currArr21 = { "Palindrome" };
    Start(start21, ref currArr21);

    string newstring21 = Reverse(currArr21[0]);
    if (CheckConditionForNumb(currArr21[0], newstring21, 4)) WriteResult(currArr21[0], "Palindrome", 0);
    else { WriteResult(currArr21[0], "Palindrome", 1); }
}

void Programm022()
{
    string[] start22 = { "Найти расстояние двух точек в 2D/3D (в 2D Z = 0)", "Enter", "int32" };
    string[] currArr22 = { "X.1", "Y.1", "Z.1", "X.2", "Y.2", "Z.2" };
    Start(start22, ref currArr22);
    string resulttext22 = "Distanse of two dots";

    double[] changearr22 = ToDoubleArray(currArr22);
    int i22 = 0;
    // result = корень из (x1-x2)^2 + (y1-y2)^2
    string result22 = Convert.ToString(Math.Round(Math.Sqrt(Math.Pow((changearr22[i22] - changearr22[i22 + 3]), 2) + Math.Pow((changearr22[i22 + 1] - changearr22[i22 + 4]), 2) + Math.Pow((changearr22[i22 + 2] - changearr22[i22 + 5]), 2)), 2));
    WriteResult(resulttext22, result22, 0);
}

void Programm023()
{
    string[] start23 = { "Показать таблицу квадратов чисел от 1 до N", "default", "int32range" };
    string[] currArr23 = { "1", "Enter N" };
    Start(start23, ref currArr23);
    int max23 = Convert.ToInt32(currArr23[1]);
    double[] newArr23 = new double[max23];
    for (int i23 = 0; i23 < max23; i23++)
    {
        newArr23[i23] = Math.Pow(Convert.ToDouble(currArr23[i23]), 2);
        WriteResult(Convert.ToString(currArr23[i23]), Convert.ToString(newArr23[i23]), 0);
    }
}

void Programm024()
{
    string[] start24 = { "Найти кубы чисел от 1 до N", "default", "int32range" };
    string[] currArr24 = { "1", "Enter N" };
    string end24 = currArr24[1];
    Start(start24, ref currArr24);
    for (int i24 = 0; i24 < currArr24.Length; i24++) currArr24[i24] = Convert.ToString(Math.Pow(Convert.ToDouble(currArr24[i24]), 3));
    WriteResult($"cubes of numbers from 1 to {end24}", StringResult(currArr24), 0);
}

void Programm025()
{
    string[] start25 = { "Найти сумму чисел от 1 до А", "default", "Int32" };
    string[] currArr25 = { "1", "A number" };
    Start(start25, ref currArr25);
    int SN25 = Convert.ToInt32(currArr25[0]);
    int leng25 = Convert.ToInt32(currArr25[1]);
    double summ25 = 0;
    for (int i25 = 0; i25 < leng25; i25++) summ25 += SN25;
    WriteResult($"{leng25}", Convert.ToString(summ25), 0);
}

void Programm026()
{
    string[] start26 = { "Возведите число А в натуральную степень B, используя цикл", "Enter", "Int32" };
    string[] currArr26 = { "A number", "B number" };
    Start(start26, ref currArr26);
    int AN0 = Convert.ToInt32(currArr26[0]);
    int leng26 = Convert.ToInt32(currArr26[1]);
    double result = 1;
    for (int i26 = 0; i26 < leng26; i26++) result *= AN0;
    WriteResult($"{currArr26[0]} in {currArr26[1]}", Convert.ToString(result), 0);
}

void Programm027028()
{
    string[] start27 = { "Определить количество цифр в цифре и посчитать сумму цифр в цифре", "Enter", "Int32" };
    string[] currArr27 = { "Number" };
    Start(start27, ref currArr27);
    int resultCount = GetIntergerNumericalPosition(currArr27[0]);
    int summ = 0;
    int[] numb27 = ToIntArrayFromString(currArr27[0]);
    foreach (int n in numb27) summ += n;
    WriteResult("count numb", $"{resultCount}", 0);
    WriteResult("summ numb", $"{summ}", 0);
}

void Programm029()
{
    string[] start29 = { "Написать программу вычисления чисел от 1 до N", "Enter", "int32range" };
    string[] currArr29 = { "1", "327" };
    Start(start29, ref currArr29);
    WriteResult($"{currArr29.Length}", StringResult(currArr29), 0);
}

void Programm030()
{
    string[] start30 = { "Показать кубы чисел, заканчивающихся на четную цифру", "Random", "Double" };
    string[] currArr30 = { "-5", "5", "10" };
    Start(start30, ref currArr30);
    double[] newArr30 = ToDoubleArray(currArr30);
    Console.WriteLine("Результат для нахождения кубов чисел");
    for (int i = 0; i < newArr30.Length; i++) if (Math.Pow(newArr30[i], 3) % 2 == 0) Console.Write($"{Math.Pow(newArr30[i], 3)} ");
}

void Programm031()
{
    string[] start31 = {"Задать массив из 8 элементов и вывести их на экран", "Enter", "Int32"};
    string[] currArr31 = { "First", "Second", "Third", "Fourth", "Fiveth", "Secondth", "Seventh", "Eighth"};
    Start(start31, ref currArr31);
    WriteResult($"8 elements", StringResult(currArr31), 0);
}

void Programm032()
{
    string[] start32 = {"Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран", "Random", "Int32"};
    string[] currArr32 = { "0", "1", "8"};
    Start(start32, ref currArr32);
    WriteResult($"8 elements", StringResult(currArr32), 0);
}

void Programm033()
{
    string[] start33 = {"Задать массив из 12 элементов, заполненных числами из [-9 ,9]. Найти сумму положительных/отрицательных элементов массива", "Random", "Int32"};
    string[] currArr33 = { "-9", "9", "12"};
    Start(start33, ref currArr33);

    int summPositiv33 = 0, summNegative33 = 0;
    int numbArr33 = 0;
    foreach (string numb33 in currArr33) 
    {
        numbArr33 = Convert.ToInt32(numb33);
        if ( numbArr33 > 0) summPositiv33 += numbArr33;
        else summNegative33 += numbArr33;
    }
    WriteResult("Positiv", $"{summPositiv33}", 0);
    WriteResult("Negative", $"{summNegative33}", 0);
}

void Programm034()
{
    string[] start34 = {"Написать программу замену элементов массива на противоположные", "Random", "Int32range"};
    string[] currArr34 = { "-100", "100", "15"};
    Start(start34, ref currArr34);

    Console.WriteLine($"Созданный массив: {StringResult(currArr34)}");
    for (int i = 0, leng = currArr34.Length, temp; i < leng; i++)
    {
        temp = Convert.ToInt32(currArr34[i]);
        currArr34[i] = Convert.ToString(temp * (-1));
    }
    WriteResult("opposite", StringResult(currArr34), 0);
}

void Programm035()
{
    string[] start35 = { "Определить присутствует ли в заданном массиве некоторое число", "Random", "Int32range" };
    string[] currArr35 = { "Введите минимальные значения", "Введите максимальные значения", "Введите количество" };
    string[] findArr35 = { "Find number" };
    Start(start35, ref currArr35);
    InputData(findArr35, "Int32");

    string find35 = findArr35[0];
    string result = "Not found";
    for (int i = 0; i < findArr35.Length; i++) if (findArr35[i] == find35) result = $" Это число присутствует, находится {i + 1} по порядку";
    Console.WriteLine(result);
}

void Programm036()
{
    string[] start36 = { "Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных/четных чисел", "Random", "Int32range,3" };
    string[] currArr36 = { "Введите минимальные значения", "Введите максимальные значения", "Введите количество" };
    Start(start36, ref currArr36);
    int even36 = 0, uneven36 = 0;
    for (int i = 0, leng = currArr36.Length; i < leng; i++)
    {
        if (Convert.ToInt32(currArr36[i]) % 2 == 0) even36++;
        else uneven36++;
    }
    WriteResult("even", $"{even36}", 0);
    WriteResult("uneven", $"{uneven36}", 0);
}

void Programm037()
{
    string[] start37 = { "В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]", "Random", "Int32range" };
    string[] currArr37 = { "Введите минимальные значения", "Введите максимальные значения", "123" };
    int[] settings37 = { 10 , 99 };
    Start(start37, ref currArr37);

    int count37 = 0;
    int min = settings37[0], max = settings37[1], temp = 0;
    foreach (string s in currArr37)
    {
        temp = Convert.ToInt32(s);
        if (min <= temp && max >= temp) count37++;
    }
    WriteResult($"count element of [{min};{max}]", $"{count37}", 0);
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


