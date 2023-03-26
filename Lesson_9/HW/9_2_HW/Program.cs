// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int result = 0;
int ValuesSet(int M, int N)
{
    if (N < M) return 0;
    if (N >= 0)
    ValuesSet(M, N - 1);
    return result += N;
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
ValuesSet(num1, num2);
Console.WriteLine(result);