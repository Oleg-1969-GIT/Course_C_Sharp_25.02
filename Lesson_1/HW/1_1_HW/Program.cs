﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

string a = Console.ReadLine()!;
string b = Console.ReadLine()!;
int a = int.Parse(a);
int b = int.Parse(a);

if (a>b) Console.Write("max = "+a);
    else Console.Write("max = "+b);