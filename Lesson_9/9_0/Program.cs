﻿// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"

void ValuesSet(int N)
{
    if (N == 0) return;
    ValuesSet(N - 1);
    Console.Write($"{N} ");
}

int num = int.Parse(Console.ReadLine()!);
ValuesSet(num);