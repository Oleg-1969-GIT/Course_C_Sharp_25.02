// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
}

double[,] MassNums(int row, int column, double from, double to)
{
    double[,] arr = new double[row, column];
    Random random = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Abs(Math.Round(random.NextDouble()*10, 1));

    return arr;
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
double start = double.Parse(Console.ReadLine()!);
double stop = double.Parse(Console.ReadLine()!);

double[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);