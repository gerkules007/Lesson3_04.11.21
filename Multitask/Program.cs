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
        Console.WriteLine("Введите команду");
        string input = Console.ReadLine()!;
        System.Threading.Thread.Sleep(1000);
        bool check = int.TryParse(input, out int number);

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
                ChooseProgramm(input);
                Console.WriteLine();
                break;
            case false:
                switch (input)
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
void ChooseProgramm(string position)
{
    switch (position)
    {
        case "0":
            string[] text = { "Введите первое число", "Введите второе число" };
            double[] arr = CreateArrayInt32(text);
            for (int i = 0; i < text.Length; i++) InputData(text, arr, i);
            Console.WriteLine(string.Join(" ", arr));
            break;
        default:
            Console.WriteLine("Такой задачи не существует, попробуйте еще раз");
            break;
    }
}

// Метод ввода данных в вычисляемый массив (проверяет на правильность ввода данных)
void InputData(string[] array1, double[] array2, int i)
{
    double input;
    do
    {
        Console.WriteLine(array1[i]);
    } while (!Double.TryParse(Console.ReadLine(), out input));
    array2[i] = input;
}

double[] CreateArrayInt32(string[] array1)
{
    double[] array2 = { -1 };
    int count = array1.Length;
    Array.Resize(ref array2, count);
    return array2;
}

// Main
Console.WriteLine("Введите свое имя");
var name = Console.ReadLine()!;
Console.Clear();
System.Threading.Thread.Sleep(1000);
Console.WriteLine($"Приветствую тебя, {name}");
System.Threading.Thread.Sleep(2000);
Enterprogram();

