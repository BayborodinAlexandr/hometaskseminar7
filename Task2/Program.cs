// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// Пример:
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите два натуральных числа M и N для вычисления функции Аккермана:");
int m = ReadNaturalNumber("M");
int n = ReadNaturalNumber("N");

int result = AckermannFunction(n, m);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {result}");

static int ReadNaturalNumber(string name)
{
    Console.WriteLine($"Введите значение натурального числа {name}:");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num <= 0)
    {
        Console.WriteLine($"Вы ввели ненатуральное число для {name}. Пожалуйста, введите натуральное число.");
        return ReadNaturalNumber(name);
    }
    return num;
}

static int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AckermannFunction(m - 1, 1);
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}