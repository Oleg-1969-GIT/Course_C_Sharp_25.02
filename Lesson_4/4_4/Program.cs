// Напишите программу, которая выводит массив из 8 элементов
// заполненный нулями и единичками в случайном порядке.
// [0,1,0,0,0,1,1,0]

void Massiv(int length)
{
    int[] R = new int[length];
    for (int i = 0; i < length; i++)
    {
        R[i] = new Random().Next(2);
        Console.Write($" " + R[i]);
    }
}
Massiv(int.Parse(Console.ReadLine()!));