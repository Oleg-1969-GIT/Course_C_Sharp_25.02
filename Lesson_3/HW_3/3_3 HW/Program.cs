﻿// Задача 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Kube(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"-> " + i * i * i);
    }
}
int x = int.Parse(Console.ReadLine()!);
Kube(x);