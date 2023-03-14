// Напишите программу, которая задаёт массив из 8 элементов 
// случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции
// (пригодится в следующих задачах)

void Massiv(int length)
{
    int[] R = new int[length];
    for (int i = 0; i < length; i++)
    {
        R[i] = new Random().Next(10);
        Console.Write(" : " + R[i]);
    }
}
Massiv(int.Parse(Console.ReadLine()!));
Console.WriteLine();