// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.WriteLine("Введите размеры массива");
int row = int.Parse(Console.ReadLine()!);
int column = int.Parse(Console.ReadLine()!);
int[,] array = new int[row, column];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random().Next(10, 50);
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "  ");
    Console.WriteLine();
}

Console.WriteLine("Введите координаты элемента");
Console.WriteLine("Строка?");
int r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Столбец?");
int c = int.Parse(Console.ReadLine()!);

if (r > row || c > column)
    Console.WriteLine("Нет такого элемента");
else
{
    object result = array.GetValue(r - 1, c - 1)!;
    Console.WriteLine("Значение элемента: " + result);
}