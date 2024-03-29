﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
// y = k1*x + b1, y = k2*x + b2; значения b1, k1, b2, k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CrossLine(double b1, double k1, double b2, double k2)
{
    if ((k1 == k2) && (b1 == b2))
        Console.WriteLine("Прямые совпадают");

    else if (k1 == k2)
        Console.WriteLine("Прямые параллельны");

    //return;

    else
    {
        double crossX = (b1 - b2) / (k2 - k1);
        double crossY = (k1 * (b2 - b1) / (k1 - k2) + b1);
        Console.WriteLine($"Координата пересечения X =  {crossX}");
        Console.WriteLine($"Координата пересечения У =  {crossY}");
    }
    return;
}
Console.WriteLine("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);
CrossLine(b1, k1, b2, k2);