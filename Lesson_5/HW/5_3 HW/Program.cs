// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

void Main(int[] args)
{
    int a, i, n, sum = 0, sumo = 0;
    int[] m = new int[100];

    Random rand = new Random();
    n = 11;
    Console.WriteLine("Исходный массив");
    for (i = 0; i < n; i++)
    {
        m[i] = rand.Next(0, 50);
        Console.Write(m[i] + " ");
    }

    int min = m[0];
    int max = m[0];

    for (i = 0; i < n; i++)
    {
        if (m[i] < min)
        {
            min = m[i];
        }
        else if (m[i] > max)
        {
            max = m[i];
        }
    }
    Console.WriteLine("\nМинимальный элемент: " + min);
    Console.WriteLine("Максимальный элемент: " + max);
    for (i = 0; i < n; i++)
    {
        Console.Write(m[i] + " ");
    }
    Console.ReadKey();
}
Main(min, max);