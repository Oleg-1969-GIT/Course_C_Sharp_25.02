﻿// 1. Напишите программу, которая на вход принимает трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

int TakeNum(int num)
{
    Console.WriteLine("Число: "+num);
    return num % 10;
}
// int num = new Random().Next(100, 1000);
int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine("Последняя цифра: "+result);
// Console.WriteLine(num);
// получаем случайное трехзначное число
// Console.WriteLine(num % 10);
// выдает остаток от деления