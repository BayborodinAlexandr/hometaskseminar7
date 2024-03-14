// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// Пример:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

int arraySize = EnteringArrayParameters("Введите размер массива: ");
if (arraySize <= 0)
{
    Console.WriteLine("Число должно быть натуральным и больше нуля!");
    arraySize = EnteringArrayParameters("Введите размер массива: ");
}

int minimumValueArray = EnteringArrayParameters("Введите минимальное значение элемента массива (больше нуля): ");
if (minimumValueArray <= 0)
{
    Console.WriteLine("Минимальное значение должно быть больше нуля!");
    minimumValueArray = EnteringArrayParameters("Введите минимальное значение элемента массива (больше нуля): ");
}

int maximumValueArray = EnteringArrayParameters("Введите максимальное значение элемента массива (больше нуля): ");
if (maximumValueArray <= 0 || maximumValueArray <= minimumValueArray)
{
    if (maximumValueArray <= 0)
    {
        Console.WriteLine("Максимальное значение должно быть больше нуля!");
    }
    else
    {
        Console.WriteLine("Максимальное значение должно быть больше минимального!");
    }
    minimumValueArray = EnteringArrayParameters("Введите минимальное значение элемента массива (больше нуля): ");
    maximumValueArray = EnteringArrayParameters("Введите максимальное значение элемента массива (больше нуля): ");
}

int[] arrayMain = CreateArrayRndInt(arraySize, minimumValueArray, maximumValueArray);
Console.Write("[");
PrintArray(arrayMain);
Console.Write("]");
Console.Write(" => ");
PrintReverseArray(arrayMain, arrayMain.Length);
Console.WriteLine();

int EnteringArrayParameters(string prompt)
{
    Console.WriteLine(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    FillArray(array, rnd, min, max, 0);
    return array;
}

void FillArray(int[] array, Random rnd, int min, int max, int index)
{
    if (index < array.Length)
    {
        array[index] = rnd.Next(min, max);
        FillArray(array, rnd, min, max, index + 1);
    }
}

void PrintArray(int[] array, int i = 0)
{
    if (i < array.Length - 1)
    {
        Console.Write($"{array[i]}, ");
        PrintArray(array, i + 1);
    }
    else if (i == array.Length - 1)
    {
        Console.Write($"{array[i]}");
    }
}

void PrintReverseArray(int[] array, int arraySize)
{
    if (arraySize == 0) return;
    Console.Write($"{array[arraySize - 1]} ");
    PrintReverseArray(array, arraySize - 1);
}