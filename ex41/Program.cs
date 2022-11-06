// 41. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример: 0,7,8,-2,-2 -> 2

Console.Write("Введите числа через запятую: ");
string[] getArray = Console.ReadLine().Split(",");
int[] numericArray = ConvertArrayToInt(getArray);
int result = SearchPositive(numericArray);
Console.Write("Получен ряд чисел:"); 
PrintArray(numericArray); // вывод на экран полученного массива чисел
Console.WriteLine($"Кол-во элементов больше нуля: {result}");

int SearchPositive(int[] array) // метод нахождения кол-ва полож.чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] ConvertArrayToInt(string[] array) 
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = Convert.ToInt32(array[i]);
    }
    return result;
}

void PrintArray(int[] num) // метод для вывода массива на экран
{
    int pos = 0;
    while (pos < num.Length)
    {
        Console.Write($"{num[pos]} ");
        pos++;
    }
    Console.WriteLine();
}