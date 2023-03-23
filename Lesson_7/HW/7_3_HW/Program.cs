// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Print(double[,] arr)
{
    int column = arr.GetLength(0);
    int row = arr.GetLength(1);

    for (int i = 0; i < column; i++)
    {
        for (int j = 0; j < row; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
}

double[,] MassNums(int column, int row, double from, double to)
{
    double[,] arr = new double[column, row];
    Random random = new Random();

    for (int i = 0; i < column; i++)
    {
        for (int j = 0; j < row; j++)
        {
            arr[i, j] = Math.Round(random.NextDouble() * 10, 1);
        }
    }
    return arr;
}

Console.WriteLine("Введите число строк и столбцов:");
int m_row = int.Parse(Console.ReadLine()!);
int n_column = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите диапазон чисел в массиве:");
double start = double.Parse(Console.ReadLine()!);
double stop = double.Parse(Console.ReadLine()!);

double[,] mass = MassNums(m_row, n_column, start, stop);
Print(mass);

void Averages(double[,] mass)
{
    double[] summ = new double[n_column];
    for (int i = 0; i < m_row; i++)
    {
        for (int j = 0; j < n_column; j++)
        {
            summ[j] += Math.Round(mass[i, j], 1);
        }
    }
    Console.WriteLine("Среднее арифметическое в каждом столбце: ");

    for (int j = 0; j < n_column; j++)
    {
        Console.Write(summ[j] / m_row + " ");
    }
}

Averages(mass);
Console.WriteLine();