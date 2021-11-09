// Методы для работы
// Метод свитч
/*
    Начальные аргуметны
    Постепенное выполнение методов
    Вызов метода печати
*/

// Основная функция
/*
Приветствие
Выбор функций
Защита от случаный нажатий
Подключение значений
Расчет
Вывод на экран
*/

// Алгоритм:
// Используем вводы данных
// Используем присваиваемые значения
// Рассчитываем значения через методы

// Метод ввода данных
void InputData(string[] array1, int[] array2, int i)
{
    int input;
    do
    {
        Console.WriteLine(array1[i]);
    } while (!Int32.TryParse(Console.ReadLine(), out input));
    array2[i] = input;
}

int[] CreateArrayInt32(string[] array1)
{
    int[] array2 = { -1 };
    int count = array1.Length;
    Array.Resize(ref array2, count);
    return array2;
}

string[] text = { "Введите первое число", "Введите второе число" };
int[] arr = CreateArrayInt32(text);
for (int i = 0; i < text.Length; i++) InputData(text, arr, i);
Console.WriteLine(string.Join(" ", arr));