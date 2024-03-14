﻿// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

//Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите значение натурального числа M:");
if (int.TryParse(Console.ReadLine(), out int m) && m > 0)
{
    Console.WriteLine("Введите значение натурального числа N:");
    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
    {
        Console.Write($"M = {m}; N = {n} -> \"");
        OutputNaturalNumbers(m, n);
        Console.WriteLine("\"");
    }
    else
    {
        Console.WriteLine("Вы ввели ненатуральное число для N. Пожалуйста, введите натуральное число.");
    }
}
else
{
    Console.WriteLine("Вы ввели ненатуральное число для M. Пожалуйста, введите натуральное число.");
}

void OutputNaturalNumbers(int M, int N)
{
    if (M == N)
    {
        if (N >= 0) Console.Write($"{N}");
    }
    else
    {
        if (M < N)
        {
            OutputNaturalNumbers(M, N - 1);
            if (N >= 0) Console.Write($", {N}");
        }
        else if (M > N)
        {
            if (N >= 0) Console.Write($"{M}, ");
            OutputNaturalNumbers(M - 1, N);
        }
    }
}
