﻿// Задайте значения М и N. Напишите программу, которая выведет все чётные натуральные
// числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void ValuesSet(int M, int N)
{
    if (N < M) return;
    ValuesSet(M, N - 1);
    if (N % 2 == 0)
    Console.Write($"{N}, ");
}
Console.WriteLine();
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
ValuesSet(num1, num2);